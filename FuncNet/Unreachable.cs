using System;

namespace FuncNet;

// Alternative to UnreachableException for netstandard
internal sealed class Unreachable : Exception;