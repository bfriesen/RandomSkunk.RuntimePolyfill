# RandomSkunk.RuntimePolyfill [![NuGet](https://img.shields.io/nuget/v/RandomSkunk.RuntimePolyfill.svg)](https://www.nuget.org/packages/RandomSkunk.RuntimePolyfill)

*Provides a source generator that adds internal versions of types missing from older versions of .NET*

The goal of this project is to allow libraries and apps that target earlier versions of .NET to use laguage features from later versions of C#.

## Supported versions

- .NET: 5, 6, 7, 8
- .NET Core: 2.0, 2.1, 2.2, 3.0, 3.1
- .NET Standard: 2.0, 2.1
- .NET Framework: 4.6.1, 4.6.2, 4.7, 4.7.1, 4.7.2, 4.8

## Types Implemented

- [System.Index](https://learn.microsoft.com/en-us/dotnet/api/system.index)
- [System.Range](https://learn.microsoft.com/en-us/dotnet/api/system.range)
- [System.Diagnostics.StackTraceHiddenAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.stacktracehiddenattribute)
- [System.Diagnostics.CodeAnalysis.AllowNullAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.allownullattribute)
- [System.Diagnostics.CodeAnalysis.ConstantExpectedAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.constantexpectedattribute)
- [System.Diagnostics.CodeAnalysis.DisallowNullAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.disallownullattribute)
- [System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.doesnotreturnattribute)
- [System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.doesnotreturnifattribute)
- [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembersAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.dynamicallyaccessedmembersattribute)
- [System.Diagnostics.CodeAnalysis.DynamicDependencyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.dynamicdependencyattribute)
- [System.Diagnostics.CodeAnalysis.ExperimentalAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.experimentalattribute)
- [System.Diagnostics.CodeAnalysis.MaybeNullAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.maybenullattribute)
- [System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.maybenullwhenattribute)
- [System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.membernotnullwhenattribute)
- [System.Diagnostics.CodeAnalysis.NotNullAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.notnullattribute)
- [System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.notnullifnotnullattribute)
- [System.Diagnostics.CodeAnalysis.NotNullWhenAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.notnullwhenattribute)
- [System.Diagnostics.CodeAnalysis.RequiresAssemblyFilesAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.requiresassemblyfilesattribute)
- [System.Diagnostics.CodeAnalysis.RequiresDynamicCodeAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.requiresdynamiccodeattribute)
- [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.requiresunreferencedcodeattribute)
- [System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.setsrequiredmembersattribute)
- [System.Diagnostics.CodeAnalysis.StringSyntaxAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.stringsyntaxattribute)
- [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessageAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.unconditionalsuppressmessageattribute)
- [System.Diagnostics.CodeAnalysis.UnscopedRefAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.codeanalysis.unscopedrefattribute)
- [System.Runtime.CompilerServices.CallerArgumentExpressionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.callerargumentexpressionattribute)
- [System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.compilerfeaturerequiredattribute)
- [System.Runtime.CompilerServices.IsExternalInit](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isexternalinit)
- [System.Runtime.CompilerServices.RequiredMemberAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.requiredmemberattribute)
- [System.Runtime.CompilerServices.RuntimeHelpers.GetSubArray](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.runtimehelpers.getsubarray)
