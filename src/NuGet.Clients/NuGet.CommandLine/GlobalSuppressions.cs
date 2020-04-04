﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1802:Field 'UserAgent' is declared as 'readonly' but is initialized with a constant value. Mark this field as 'const' instead.", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.CommandLine.CommandLineConstants.UserAgent")]
[assembly: SuppressMessage("Build", "CA1802:Field 'CredentialProviderPattern' is declared as 'readonly' but is initialized with a constant value. Mark this field as 'const' instead.", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.CommandLine.ExtensionLocator.CredentialProviderPattern")]
[assembly: SuppressMessage("Build", "CA1823:Unused field 'PackagesFolder'.", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.CommandLine.ProjectFactory.PackagesFolder")]
[assembly: SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.Common.MSBuildUser._frameworkAssembly")]
[assembly: SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.Common.MSBuildUser._msbuildAssembly")]
[assembly: SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.Common.MSBuildUser._msbuildDirectory")]
[assembly: SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.Common.MSBuildUser._projectCollectionType")]
[assembly: SuppressMessage("Build", "CA1051:Do not declare visible instance fields", Justification = "<Pending>", Scope = "member", Target = "~F:NuGet.Common.MSBuildUser._projectType")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void AssemblyMetadataExtractor.ExtractMetadata(PackageBuilder builder, string assemblyPath)', validate parameter 'builder' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.AssemblyMetadataExtractor.ExtractMetadata(NuGet.Packaging.PackageBuilder,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void CommandLineParser.ExtractOptions(ICommand command, IEnumerator<string> argsEnumerator)', validate parameter 'command' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.CommandLineParser.ExtractOptions(NuGet.CommandLine.ICommand,System.Collections.Generic.IEnumerator{System.String})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ICommand CommandLineParser.ParseCommandLine(IEnumerable<string> commandLineArgs)', validate parameter 'commandLineArgs' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.CommandLineParser.ParseCommandLine(System.Collections.Generic.IEnumerable{System.String})~NuGet.CommandLine.ICommand")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'CommandLineSourceRepositoryProvider.CommandLineSourceRepositoryProvider(IPackageSourceProvider packageSourceProvider)', validate parameter 'packageSourceProvider' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.CommandLineSourceRepositoryProvider.#ctor(NuGet.Configuration.IPackageSourceProvider)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'HashAlgorithmName CommandLineUtility.ParseAndValidateHashAlgorithmFromArgument(string argumentValue, string argumentName, SigningSpecifications spec)', validate parameter 'spec' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.CommandLineUtility.ParseAndValidateHashAlgorithmFromArgument(System.String,System.String,NuGet.Packaging.Signing.SigningSpecifications)~NuGet.Common.HashAlgorithmName")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IDictionary<OptionAttribute, PropertyInfo> CommandManager.GetCommandOptions(ICommand command)', validate parameter 'command' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.CommandManager.GetCommandOptions(NuGet.CommandLine.ICommand)~System.Collections.Generic.IDictionary{NuGet.OptionAttribute,System.Reflection.PropertyInfo}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void CommandManager.RegisterCommand(ICommand command)', validate parameter 'command' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.CommandManager.RegisterCommand(NuGet.CommandLine.ICommand)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void Console.Log(ILogMessage message)', validate parameter 'message' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Console.Log(NuGet.Common.ILogMessage)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void Console.PrintJustified(int startIndex, string text, int maxWidth)', validate parameter 'text' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Console.PrintJustified(System.Int32,System.String,System.Int32)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void Console.ReadSecureString(SecureString secureString)', validate parameter 'secureString' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Console.ReadSecureString(System.Security.SecureString)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'void Console.WriteError(object value)', validate parameter 'value' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Console.WriteError(System.Object)")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<object>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Console.WriteError(System.String)")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<object>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Console.WriteWarning(System.Boolean,System.String)")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<object>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Console.WriteWarning(System.String)")]
[assembly: SuppressMessage("Build", "CA1801:Parameter project of method LibraryDetail is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.DiagnosticCommands.LibraryDetail(NuGet.ProjectModel.PackageSpec,NuGet.ProjectModel.LockFile,System.String,System.String)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1822:Member GetInstalledPackageReferences does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.DownloadCommandBase.GetInstalledPackageReferences(System.String,System.Boolean)~System.Collections.Generic.IEnumerable{NuGet.Packaging.PackageReference}")]
[assembly: SuppressMessage("Build", "CA1801:Parameter token of method GetFolderPackagesAsync is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.InstallCommandProject.GetFolderPackagesAsync(System.Threading.CancellationToken)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{NuGet.Packaging.PackageReference}}")]
[assembly: SuppressMessage("Build", "CA2208:Method AddProperty passes parameter name 'value' as the message argument to a ArgumentException constructor. Replace this argument with a descriptive message and pass the parameter name in the correct position.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.AddProperty(System.Collections.Generic.List{System.String},System.String,System.String)")]
[assembly: SuppressMessage("Build", "CA1303:Method 'void MsBuildUtility.AddProperty(List<string> args, string property, string value)' passes a literal string as parameter 'message' of a call to 'ArgumentException.ArgumentException(string message)'. Retrieve the following string(s) from a resource table instead: \"value\".", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.AddProperty(System.Collections.Generic.List{System.String},System.String,System.String)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IEnumerable<string> MsBuildUtility.GetAllProjectFileNames(string solutionFile, string pathToMsbuildDir)', validate parameter 'pathToMsbuildDir' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetAllProjectFileNames(System.String,System.String)~System.Collections.Generic.IEnumerable{System.String}")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'GetInstalledSxsToolsets' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetInstalledSxsToolsets~System.Collections.Generic.List{NuGet.CommandLine.MsBuildToolset}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string MsBuildUtility.GetMSBuildArguments(string entryPointTargetPath, string inputTargetPath, string nugetExePath, string solutionDirectory, string solutionName, string restoreConfigFile, string[] sources, string packagesDirectory, MsBuildToolset toolset, RestoreLockProperties restoreLockProperties, IEnvironmentVariableReader reader)', validate parameter 'sources' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetMSBuildArguments(System.String,System.String,System.String,System.String,System.String,System.String,System.String[],System.String,NuGet.CommandLine.MsBuildToolset,NuGet.ProjectModel.RestoreLockProperties,NuGet.Common.IEnvironmentVariableReader)~System.String")]
[assembly: SuppressMessage("Build", "CA1801:Parameter console of method GetMsBuildDirectoryInternal is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetMsBuildDirectoryInternal(System.String,NuGet.CommandLine.IConsole,System.Collections.Generic.IEnumerable{NuGet.CommandLine.MsBuildToolset},System.Func{NuGet.Common.IEnvironmentVariableReader,System.String})~NuGet.CommandLine.MsBuildToolset")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'MsBuildToolset MsBuildUtility.GetMsBuildDirectoryInternal(string userVersion, IConsole console, IEnumerable<MsBuildToolset> installedToolsets, Func<IEnvironmentVariableReader, string> getMsBuildPathInPathVar)', validate parameter 'getMsBuildPathInPathVar' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetMsBuildDirectoryInternal(System.String,NuGet.CommandLine.IConsole,System.Collections.Generic.IEnumerable{NuGet.CommandLine.MsBuildToolset},System.Func{NuGet.Common.IEnvironmentVariableReader,System.String})~NuGet.CommandLine.MsBuildToolset")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'GetMsBuildPathInPathVar' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetMsBuildPathInPathVar(NuGet.Common.IEnvironmentVariableReader)~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Task<DependencyGraphSpec> MsBuildUtility.GetProjectReferencesAsync(MsBuildToolset msbuildToolset, string[] projectPaths, int timeOut, IConsole console, bool recursive, string solutionDirectory, string solutionName, string restoreConfigFile, string[] sources, string packagesDirectory, RestoreLockProperties restoreLockProperties)', validate parameter 'msbuildToolset' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetProjectReferencesAsync(NuGet.CommandLine.MsBuildToolset,System.String[],System.Int32,NuGet.CommandLine.IConsole,System.Boolean,System.String,System.String,System.String,System.String[],System.String,NuGet.ProjectModel.RestoreLockProperties)~System.Threading.Tasks.Task{NuGet.ProjectModel.DependencyGraphSpec}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'bool.ToString()' could vary based on the current user's locale settings. Replace this call in 'MsBuildUtility.GetProjectReferencesAsync(MsBuildToolset, string[], int, IConsole, bool, string, string, string, string[], string, RestoreLockProperties)' with a call to 'bool.ToString(IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetProjectReferencesAsync(NuGet.CommandLine.MsBuildToolset,System.String[],System.Int32,NuGet.CommandLine.IConsole,System.Boolean,System.String,System.String,System.String,System.String[],System.String,NuGet.ProjectModel.RestoreLockProperties)~System.Threading.Tasks.Task{NuGet.ProjectModel.DependencyGraphSpec}")]
[assembly: SuppressMessage("Build", "CA1308:In method 'GetProjectReferencesAsync', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.GetProjectReferencesAsync(NuGet.CommandLine.MsBuildToolset,System.String[],System.Int32,NuGet.CommandLine.IConsole,System.Boolean,System.String,System.String,System.String,System.String[],System.String,NuGet.ProjectModel.RestoreLockProperties)~System.Threading.Tasks.Task{NuGet.ProjectModel.DependencyGraphSpec}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool MsBuildUtility.IsMsBuildBasedProject(string projectFullPath)', validate parameter 'projectFullPath' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.IsMsBuildBasedProject(System.String)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'LoadProjectCollection' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.LoadProjectCollection~System.IDisposable")]
[assembly: SuppressMessage("Build", "CA1031:Modify '.ctor' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.TempFile.#ctor(System.String)")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'Dispose' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.MsBuildUtility.TempFile.Dispose")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool Program.ArgumentCountValid(ICommand command)', validate parameter 'command' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Program.ArgumentCountValid(NuGet.CommandLine.ICommand)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.StartsWith(string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.CommandLine.Program.IsWindows10(NuGet.Common.ILogger)' with a call to 'string.StartsWith(string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Program.IsWindows10(NuGet.Common.ILogger)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'MainCore' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Program.MainCore(System.String,System.String[])~System.Int32")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'Program.RegisterExtensions(AggregateCatalog, IEnumerable<string>, IConsole)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Program.RegisterExtensions(System.ComponentModel.Composition.Hosting.AggregateCatalog,System.Collections.Generic.IEnumerable{System.String},NuGet.CommandLine.IConsole)")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new AssemblyCatalog(item)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.Program.RegisterExtensions(System.ComponentModel.Composition.Hosting.AggregateCatalog,System.Collections.Generic.IEnumerable{System.String},NuGet.CommandLine.IConsole)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'ProjectFactory.CreateBuilder(string, NuGetVersion, string, bool, [PackageBuilder])' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.CreateBuilder(System.String,NuGet.Versioning.NuGetVersion,System.String,System.Boolean,NuGet.Packaging.PackageBuilder)~NuGet.Packaging.PackageBuilder")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'ProjectFactory.CreateDependencyFromProject(dynamic, Dictionary<string, PackageDependency>)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.CreateDependencyFromProject(,System.Collections.Generic.Dictionary{System.String,NuGet.Packaging.Core.PackageDependency})~NuGet.Packaging.Core.PackageDependency")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'ExtractMetadata' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.ExtractMetadata(NuGet.Packaging.PackageBuilder)")]
[assembly: SuppressMessage("Build", "CA1822:Member FindDependency does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.FindDependency(NuGet.Packaging.Core.PackageIdentity,System.Collections.Generic.IEnumerable{System.Tuple{NuGet.Packaging.PackageReaderBase,NuGet.Packaging.Core.PackageDependency}})~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string ProjectFactory.InitializeProperties(IPackageMetadata metadata)', validate parameter 'metadata' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.InitializeProperties(NuGet.Packaging.IPackageMetadata)~System.String")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IProjectFactory ProjectFactory.ProjectCreator(PackArgs packArgs, string path)', validate parameter 'packArgs' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.ProjectCreator(NuGet.Commands.PackArgs,System.String)~NuGet.Commands.IProjectFactory")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, params object[])' could vary based on the current user's locale settings. Replace this call in 'ProjectFactory.WriteDetail(string, params object[])' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.WriteDetail(System.String,System.Object[])")]
[assembly: SuppressMessage("Build", "CA1801:Parameter registryKeyPath of method GetValueFromRegistryKey is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.RegistryKeyUtility.GetValueFromRegistryKey(System.String,System.String,Microsoft.Win32.RegistryKey,NuGet.Common.ILogger)~System.Object")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string ResourceHelper.GetLocalizedString(Type resourceType, string resourceNames)', validate parameter 'resourceNames' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ResourceHelper.GetLocalizedString(System.Type,System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'resourceType'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ResourceHelper.GetLocalizedString(System.Type,System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1822:Member GetPackageReferenceFile does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.RestoreCommand.GetPackageReferenceFile(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1307:The behavior of 'string.Equals(string, string)' could vary based on the current user's locale settings. Replace this call in 'NuGet.CommandLine.RestoreCommand.IsPackagesConfig(string)' with a call to 'string.Equals(string, string, System.StringComparison)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.RestoreCommand.IsPackagesConfig(System.String)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'GetNuGetVersion' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.SelfUpdater.GetNuGetVersion(System.Reflection.Assembly)~NuGet.Versioning.NuGetVersion")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new SourceCacheContext()' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.SelfUpdater.UpdateSelfFromVersionAsync(System.String,System.Boolean,NuGet.Versioning.NuGetVersion,System.String,System.Threading.CancellationToken)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'UpdateSelfFromVersionAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.SelfUpdater.UpdateSelfFromVersionAsync(System.String,System.Boolean,NuGet.Versioning.NuGetVersion,System.String,System.Threading.CancellationToken)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<string>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.SpecCommand.ExecuteCommand")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.ToString()' could vary based on the current user's locale settings. Replace this call in 'SpecCommand.ExecuteCommand()' with a call to 'string.ToString(IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.SpecCommand.ExecuteCommand")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'type'", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.TypeHelper.ChangeType(System.Object,System.Type)~System.Object")]
[assembly: SuppressMessage("Build", "CA2208:Method ExecuteCommandAsync passes 'PackagePath' as the paramName argument to a ArgumentNullException constructor. Replace this argument with one of the method's parameter names. Note that the provided parameter name should have the exact casing as declared on the method.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.VerifyCommand.ExecuteCommandAsync~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string[] CommandLineResponseFile.ParseArgsResponseFiles(string[] args)', validate parameter 'args' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.CommandLineResponseFile.ParseArgsResponseFiles(System.String[])~System.String[]")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, params object[])' could vary based on the current user's locale settings. Replace this call in 'CommandLineResponseFile.ParseArgsResponseFiles(string[], int)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.CommandLineResponseFile.ParseArgsResponseFiles(System.String[],System.Int32)~System.String[]")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'AddReferenceAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.MSBuildProjectSystem.AddReferenceAsync(System.String)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<object>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.MSBuildProjectSystem.GetProject(System.String)~")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Assembly MSBuildUser.AssemblyResolve(object sender, ResolveEventArgs args)', validate parameter 'args' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.MSBuildUser.AssemblyResolve(System.Object,System.ResolveEventArgs)~System.Reflection.Assembly")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'string PackageSourceProviderExtensions.ResolveAndValidateSource(IPackageSourceProvider sourceProvider, string source)', validate parameter 'sourceProvider' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.PackageSourceProviderExtensions.ResolveAndValidateSource(NuGet.Configuration.IPackageSourceProvider,System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA2227:Change 'Owners' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.CommandLine.Commands.TrustedSignersCommand.Owners")]
[assembly: SuppressMessage("Build", "CA2227:Change 'CertificateFingerprint' to be read-only by removing the property setter.", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.CommandLine.VerifyCommand.CertificateFingerprint")]
[assembly: SuppressMessage("Build", "CA1507:Use nameof in place of string literal 'TargetFramework'", Justification = "<Pending>", Scope = "member", Target = "~P:NuGet.Common.MSBuildProjectSystem.TargetFramework")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'ProjectFactory.CreateDependencyFromProject(dynamic, Dictionary<string, PackageDependency>)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.CreateDependencyFromProject(,System.Collections.Generic.Dictionary{System.String,NuGet.Packaging.Core.PackageDependency})~NuGet.Packaging.Core.PackageDependency")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<object>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.MSBuildProjectSystem.GetProject(System.String)~")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'ProjectFactory.CreateDependencyFromProject(dynamic, Dictionary<string, PackageDependency>)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.CommandLine.ProjectFactory.CreateDependencyFromProject(,System.Collections.Generic.Dictionary{System.String,NuGet.Packaging.Core.PackageDependency})~NuGet.Packaging.Core.PackageDependency")]
[assembly: SuppressMessage("Build", "CA1825:Avoid unnecessary zero-length array allocations.  Use Array.Empty<object>() instead.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Common.MSBuildProjectSystem.GetProject(System.String)~")]
