# FuncNet

![Build Status](https://github.com/pawelwilczewski/FuncNet/actions/workflows/ci.yml/badge.svg)
[![NuGet FuncNet](https://img.shields.io/nuget/v/FuncNet?logo=nuget)](https://www.nuget.org/packages/FuncNet/)
[![NuGet FuncNet.Analyzers](https://img.shields.io/nuget/v/FuncNet.Analyzers?logo=nuget)](https://www.nuget.org/packages/FuncNet.Analyzers/)

Library of source-generated functional utilities to use in C# with notably rich and easy-to-use
adhoc Union, Result and Option types with async support.

# Pipeline/Railway-Oriented Programming

This library is well-suited for working with railway-oriented programming approaches via Result,
Union and Option types with full monad implementations and async support.

# FuncNet

Nuget package containing the core functionality.

# FuncNet.Analyzers

Nuget package containing analyzers and code fixes dedicated for use with FuncNet.

# Getting Started

## Package Installation

To get started with FuncNet, you need to install the following packages:

1. **FuncNet** - The core package that should be referenced **only once** in your solution, typically in your
   domain/core
   project:

```xml
<PackageReference Include="FuncNet" Version="x.y.z">
    <PrivateAssets>all</PrivateAssets>
    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
</PackageReference>
```

_Referencing **FuncNet** more than once can cause type definitions duplication._

2. **FuncNet.Analyzers** - The analyzers package that should be referenced in **every project** where you want to use
   FuncNet features:

```xml
<ItemGroup>
    <PackageReference Include="FuncNet.Analyzers" Version="x.y.z" />
</ItemGroup>
```

## Configuring `funcnet.json`

FuncNet uses a configuration file `funcnet.json` to register generic type combinations for source generation.
This file is required to enable all features of **FuncNet**, and an analyzer will throw an error if it cannot find it.
By convention:

1. Create `funcnet.json` file at the **solution root level**
2. In all projects where you want to use **FuncNet**, add an `AdditionalFiles` entry to your `.csproj` file so it can be
   detected. Example entry:

```xml
<ItemGroup>
   <AdditionalFiles Include="..\funcnet.json" />
</ItemGroup>
```

3. The file will be used by the source generators and analyzers

Example `funcnet.json` file:

```json
{
  "GenericsRegistrations": [
    "int,string",
    "User,ValidationError",
    "string,bool,float"
  ]
}
```

Each entry in the `GenericsRegistrations` array represents a combination of types that will be used for source
generation of implicit conversions for Union and Result types.
These entries are automatically inserted via a code fix when using `FuncNet.Analyzers`.
