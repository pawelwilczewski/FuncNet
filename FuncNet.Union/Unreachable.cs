using System;

namespace FuncNet.Union;

// Alternative to UnreachableException for netstandard
internal sealed class Unreachable : Exception;