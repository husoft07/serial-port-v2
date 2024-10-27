# RJCP.Core.SysCompat <!-- omit in toc -->

This library provides implementation details that allow some backward
compatibility from newer .NET Core features to older .NET Framework libraries
when using newer C# Language versions.

- [1. .NET Framework Usage](#1-net-framework-usage)
  - [1.1. Conditional Version Upgrade](#11-conditional-version-upgrade)
  - [1.2. NuGet Package Reference](#12-nuget-package-reference)
- [2. Extensions](#2-extensions)
  - [2.1. CallerArgumentExpression](#21-callerargumentexpression)
  - [2.2. Throw Helpers](#22-throw-helpers)
    - [2.2.1. How Throw Helpers get the Argument Name](#221-how-throw-helpers-get-the-argument-name)
  - [2.3. SupportedOSPlatform](#23-supportedosplatform)
- [3. C# Language Features](#3-c-language-features)
  - [3.1. Init Properties](#31-init-properties)
    - [3.1.1. Feature Description](#311-feature-description)
    - [3.1.2. Enablement](#312-enablement)
  - [3.2. Required Properties](#32-required-properties)
    - [3.2.1. Enablement](#321-enablement)
- [4. Performance Metrics](#4-performance-metrics)
- [5. Version History](#5-version-history)
  - [5.1. Version 0.2.0](#51-version-020)

## 1. .NET Framework Usage

To use this library with newer C# compiler versions, extend this in your .NET
SDK project file:

### 1.1. Conditional Version Upgrade

By
[default](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version)
the highest version of .NET Framework is C# 7.3. Newer compilers can still
target older frameworks.

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFrameworks>net40;net6.0;net8.0</TargetFrameworks>
    ...

    <LangVersion Condition="'$(TargetFrameworkIdentifier)' == '.NETFramework'">10</LangVersion>
  </PropertyGroup>
</Project>
```

### 1.2. NuGet Package Reference

Add to your project a reference to `RJCP.Core.SysCompat` to your project for
.NET Core and .NET Framework.

## 2. Extensions

### 2.1. CallerArgumentExpression

| <!-- -->    | <!-- -->       |
| ----------- | -------------- |
| LangVersion | 10             |
| Framework   | .NET Framework |

C# 10 and later support the attribute `CallerArgumentExpressionAttribute` that
is provided in .NET 6.0 and later. On .NET Framework, this package provides the
attribute, that the compiler can inject code. Ensure the `LangVersion` is 10 or
later.

It is now possible to provide helper methods that can use the name of an
argument and pass it on as further arguments.

For details on how this is used, please study the implementation of
`ThrowHelper.ThrowIfNull(obj)`.

### 2.2. Throw Helpers

| <!-- -->    | <!-- -->                |
| ----------- | ----------------------- |
| LangVersion | 7.3                     |
| Framework   | .NET Framework and Core |

To resolve Code Analysis findings (e.g.
[CA1510](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1510),
[CA1511](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1511),
[CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512),
[CA1513](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1513)
and among others), helper methods have been created that can be used on older
frameworks.

| Helper                         | Rule                                                                                               | .NET Method                                                                                                                                                          | .NET Verison |
| ------------------------------ | -------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------ |
| `ThrowIfNull)`                 | [CA1510](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1510) | [`ArgumentNullException.ThrowIfNull`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception.throwifnull)                                         | 7.0 +        |
| `ThrowIfNullOrEmpty`           | [CA1511](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1511) | [`ArgumentException.ThrowIfNullOrEmpty`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception.throwifnullorempty)                                   | 7.0 +        |
| `ThrowIfNullOrEmptyMsg`        | -                                                                                                  | -                                                                                                                                                                    | -            |
| `ThrowIfNullOrWhiteSpace`      | [CA1511](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1511) | [`ArgumentException.ThrowIfNullOrWhiteSpace`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception.throwifnullorempty)                              | 7.0 +        |
| `ThrowIfNullOrWhiteSpaceMsg`   | -                                                                                                  | -                                                                                                                                                                    | -            |
| `ThrowIfZero` ¹                | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfZero`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwifzero)                             | 8.0 +        |
| `ThrowIfNegative` ¹            | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfNegative`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwifnegative)                     | 8.0 +        |
| `ThrowIfNegativeOrZero` ¹      | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfNegativeOrZero`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwifnegativeorzero)         | 8.0 +        |
| `ThrowIfEqual` ¹²              | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfEqual`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwifequal)                           | 8.0 +        |
| `ThrowIfNotEqual` ¹²           | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfNotEqual`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwifnotequal)                     | 8.0 +        |
| `ThrowIfGreaterThan` ¹³        | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfGreaterThan`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwifgreaterthan)               | 8.0 +        |
| `ThrowIfGreaterThanOrEqual` ¹³ | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwifgreaterthanorequal) | 8.0 +        |
| `ThrowIfLessThan` ¹³           | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfLessThan`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwiflessthan)                     | 8.0 +        |
| `ThrowIfLessThanOrEqual` ¹³    | [CA1512](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1512) | [`ArgumentOutOfRangeException.ThrowIfLessThanOrEqual`](https://learn.microsoft.com/en-us/dotnet/api/system.argumentoutofrangeexception.throwiflessthanorequal)       | 8.0 +        |
| `ThrowIfBetween`               | -                                                                                                  | -                                                                                                                                                                    | -            |
| `ThrowIfNotBetween`            | -                                                                                                  | -                                                                                                                                                                    | -            |
| `ThrowIfDisposed`              | [CA1513](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1513) | [`ObjectDisposedException.ThrowIf`](https://learn.microsoft.com/en-us/dotnet/api/system.objectdisposedexception.throwif)                                             | 7.0 +        |
| `ThrowIfArrayEmpty`            | -                                                                                                  | -                                                                                                                                                                    | -            |
| `ThrowIfArrayOutOfBounds`      | -                                                                                                  | -                                                                                                                                                                    | -            |
| `ThrowIfEnumUndefined`         | -                                                                                                  | -                                                                                                                                                                    | -            |
| `ThrowIfEnumHasNoFlag`         | -                                                                                                  | -                                                                                                                                                                    | -            |

Notes:

- ¹ These methods have overloads for the basic types `int`, `long`, `nint`,
  `float`, `double`, `uint`, `ulong` and `nuint`. The .NET implementation is
  slightly different taking generic types not available in older frameworks. Of
  course, for some methods where it doesn't make sense (throw if not negative or
  zero), only methods with signed types are provided.
- ² Provides an interface for `IEquatable<T>`. These use the default equatable
  for the type, and so the `value` may be `null` when comparing, in addition to
  the `other` parameter. This is how the .NET implementation also implements the
  method.
- ³ Provides an interface for `IComparable<T>`. These use the default comparer
  for the type, and so the `value` may be `null` when comparing, in addition to
  the `other` parameter. This is different to the .NET implementation.

The Package is compiled with the language version C# 10, so that projects using
this library for this feature do not need to upgrade.

The additional methods are provided, which are not part of the framework. These
methods are useful if you have your own translated strings that you wish to
provide the user. Note that the method name must change, due to the overload
`ThrowIfNullOrEmpty(string, string)` exists.

```csharp
using System;

ThrowHelper.ThrowIfNullOrEmptyMsg(message, strparam);
ThrowHelper.ThrowIfNullOrWhiteSpace(message, strparam);
```

#### 2.2.1. How Throw Helpers get the Argument Name

C# 10 and later support the attribute `CallerArgumentExpressionAttribute` that
is provided in .NET 6.0 and later. On .NET Framework, it uses the attribute
provided by this package, and the Roslyn compiler will still inject the
necessary code to provide the attribute name.

```csharp
public static void ThrowIfNull(object argument,
                               [CallerArgumentExpression(nameof(argument))] string paramName = null)
```

### 2.3. SupportedOSPlatform

| <!-- -->    | <!-- -->       |
| ----------- | -------------- |
| LangVersion | 7.3            |
| Framework   | .NET Framework |

With .NET 6.0 and later, code analysis warning [CA1416 Call Site
Reachable](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/quality-rules/ca1416)
can significantly support identifying potential failures in multi-target code.

To avoid unnecessary conditional compiles, it is convenient to define the
[`SupportedOSPlatform`](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.versioning.supportedosplatformattribute?view=net-8.0)
attribute, that the same code can compile for .NET Framework.

## 3. C# Language Features

### 3.1. Init Properties

| <!-- -->    | <!-- -->                |
| ----------- | ----------------------- |
| LangVersion | 9                       |
| Framework   | .NET Framework and Core |

It is not recommended enabling this for .NET Framework for reusable NuGet packages.

#### 3.1.1. Feature Description

C# 9 introduces two new keywords
[init](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/init).
Properties are initialised optionally. The benefit is to define properties that
are initialised at the same time the constructor is called, such that the
properties are set without having to set them within the constructor.

For example, instead of:

```csharp
public class MyClass {
  public MyClass(string prop) {
    Prop = prop;
  }

  public string Prop { get; }
}

MyClass c = new("value");
```

we can instead have:

```csharp
public class MyClass {
  public string Prop { get; init; }
}

MyClass c = new() {
  Prop = "value"
};
```

Benefit is more obvious with more properties (e.g. 3 or more), that values are
defined without having to have a lot of arguments in constructors, or variations
of parameters in the constructor.

#### 3.1.2. Enablement

The `RJCP.Core.SysCompat` library unfortunately cannot help, which is why the
feature is described here. In your assembly for .NET Framework, ensure that:

- The language version is set to 9 or greater (.NET Core 5 or later) in both the
  library defining the `init` property, and in the executable consuming the
  class with the `init` property.

  ```xml
  <PropertyGroup>
    <TargetFrameworks>net40;net462;net6.0;net8.0</TargetFrameworks>
    ...
    <LangVersion Condition="$(TargetFramework.StartsWith('net4'))">10</LangVersion>
  ```

- Add the following class, compiled only for .NET Framework (or .NET 2.1 or
  earlier also). Putting this into the `RJCP.Core.SysCompat.dll` library does
  not work. This should be in the library defining the `init` property (not
  needed in the executable consuming the class with the `init` property).

  ```csharp
  namespace System.Runtime.CompilerServices
  {
      using System.ComponentModel;

  #if NETFRAMEWORK || !NET5_0_OR_GREATER
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal static class IsExternalInit { }
  #endif
  }
  ```

### 3.2. Required Properties

| <!-- -->    | <!-- -->                |
| ----------- | ----------------------- |
| LangVersion | 11                      |
| Framework   | .NET Framework and Core |

Along with
[init](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/init),
C# 11 adds the keyword
[required](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/required),
which enforces that initialised properties must be provided.

#### 3.2.1. Enablement

If compiling with C# 10 or earlier:

| Severity | Code   | Description                                                                                               |
| -------- | ------ | --------------------------------------------------------------------------------------------------------- |
| Error    | CS8936 | Feature 'required members' is not available in C# 10.0. Please use language version 11.0 or greater.      |
| Error    | CS0656 | Missing compiler required member 'System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute..ctor' |
| Error    | CS0656 | Missing compiler required member 'System.Runtime.CompilerServices.RequiredMemberAttribute..ctor'          |

- Set the language version to 11 or greater (.NET Core 7 or later) in both the
  library defining the `required` property, and in the executable consuming the
  class with the `required` property.

  ```xml
  <PropertyGroup>
    <TargetFrameworks>net40;net462;net6.0;net8.0</TargetFrameworks>
    ...
    <LangVersion>11</LangVersion>
  ```

- Add the following class (not needed in the executable consuming the class with
  the `required` property)

  ```csharp
  namespace System.Runtime.CompilerServices
  {
      using System.ComponentModel;

  #if NETFRAMEWORK || !NET5_0_OR_GREATER
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal static class IsExternalInit { }
  #endif

  #if NETFRAMEWORK || !NET7_0_OR_GREATER
      [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field |
          AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
      internal sealed class RequiredMemberAttribute : Attribute { }

      [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
      internal sealed class CompilerFeatureRequiredAttribute : Attribute
      {
          public CompilerFeatureRequiredAttribute(string featureName)
          {
              FeatureName = featureName;
          }

          public string FeatureName { get; }
          public bool IsOptional { get; init; }

          public const string RefStructs = nameof(RefStructs);
          public const string RequiredMembers = nameof(RequiredMembers);
      }
  #endif
  }
  ```

## 4. Performance Metrics

```text
Results = net48

BenchmarkDotNet=v0.13.12 OS=Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i7-6700T CPU 2.80GHz (Skylake), 1 CPU(s), 8 logical and 4 physical core(s)
  [HOST] : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT
```

```text
Results = net6

BenchmarkDotNet=v0.13.12 OS=Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i7-6700T CPU 2.80GHz (Skylake), 1 CPU(s), 8 logical and 4 physical core(s)
  [HOST] : .NET 6.0.27 (6.0.2724.6912), X64 RyuJIT
```

```text
Results = net8

BenchmarkDotNet=v0.13.12 OS=Windows 10 (10.0.19045.4046/22H2/2022Update)
Intel Core i7-6700T CPU 2.80GHz (Skylake), 1 CPU(s), 8 logical and 4 physical core(s)
  [HOST] : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT
```

| Project 'syscompat' Type | Method                         | mean (net48) | stderr | mean (net6) | stderr | mean (net8) | stderr |
|:-------------------------|:-------------------------------|-------------:|-------:|------------:|-------:|------------:|-------:|
| ThrowIfArray             | ThrowIfArrayOutOfBounds        | 3.03         | 0.01   | 3.40        | 0.01   | 3.39        | 0.01   |
| ThrowIfEnum              | ThrowIfEnumHasFlag             | 23.25        | 0.01   | 1.38        | 0.01   | 1.15        | 0.00   |
| ThrowIfEnum              | ThrowIfEnumUndefined           | 244.13       | 0.25   | 111.84      | 0.07   | 24.06       | 0.05   |
| ThrowIfNullBenchmark     | ThrowIfNull                    | 0.30         | 0.00   | 0.00        | 0.00   | 0.00        | 0.00   |
| ThrowIfNullBenchmark     | ThrowIfNull_System             | -            | -      | 0.00        | 0.00   | 0.00        | 0.00   |
| ThrowIfNullBenchmark     | ThrowIfNullOrWhiteSpace        | 4.10         | 0.01   | 3.46        | 0.01   | 1.67        | 0.00   |
| ThrowIfNullBenchmark     | ThrowIfNullOrWhiteSpace_System | -            | -      | -           | -      | 1.58        | 0.00   |
| ThrowIfNullBenchmark     | ThrowIfZero                    | 0.01         | 0.00   | 0.00        | 0.00   | 0.00        | 0.00   |
| ThrowIfNullBenchmark     | ThrowIfZero_System             | -            | -      | -           | -      | 0.00        | 0.00   |

## 5. Version History

### 5.1. Version 0.2.0

- Initial Version
