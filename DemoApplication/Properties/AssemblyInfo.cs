using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SharpKit.JavaScript;
using System;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DemoApplication")]
[assembly: AssemblyDescription("Demo Application")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Digital Primates")]
[assembly: AssemblyProduct("Demo Application")]
[assembly: AssemblyCopyright("Copyright © LTN Consulting dba/ Digital Primates 2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("f52d909d-b3c5-4899-94a5-1a2271a4aad5")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: JsExport(CodeInjectionFilename = "bin/sharp_core.js", DefaultFilenameAsCsFilename = true, FilenameFormat = "generated/{0}",GenerateSourceMaps = false)]

[assembly: JsMergedFile(Filename = "generated/initial_dependencies.js", Sources = new String[]{
    "generated/startup/DemoModule.js",
    "generated/startup/Startup.js"
}, Minify = false)]
