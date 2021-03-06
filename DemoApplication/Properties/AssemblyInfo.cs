﻿using System.Reflection;
using System.Runtime.InteropServices;
using SharpKit.JavaScript;
using System;
using randori.attributes;

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
[assembly: JsExport(CodeInjectionFilename = "bin/sharp_core.js", 
                    DefaultFilenameAsCsFilename = true, 
                    FilenameFormat = "generated/demo/{0}", 
                    GenerateSourceMaps = false)]

[assembly: JsType(JsMode.Prototype, OmitCasts = true, NativeJsons = true)]

//This defines any JS files you want to be merged together and available at startup
[assembly: JsMergedFile(Filename = "generated/initial_dependencies.js", Sources = new String[]{
    "generated/demo/startup/Startup.js"
}, Minify = false)]

//This defines any HTML files you wish to be merged together and available at Startup.
//In actuality, it creates a class named HtmlMergedFile where all of these files are available via a JS method
[assembly: HtmlMergedFile(Filename = "generated/merged_fragments.js", Sources = new String[] {
    "fragment/mergedFragment1.html",
    "fragment/mergedFragment2.html"
})]
