using System.Reflection;
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

// These are the default SharpKit export options used with Randori
//
//      CodeInjectionFilename - tells sharpkit to but the SharpKit specific code in one file (sharp_core in this case) instead of littering it in each generated 'class' file
//      DefaultFilenameAsCsFilename - tells sharpkit to make a Js file for each Cs file, named the same
//      FilenameFormat - all generated content, will be added to a generated folder in a sub-directory defined by the rootnamespace. 
//                       !!!!! If you change your root namespace, you must update this option !!!!
//      GenerateSourceMaps - SharpKit can generated Js to Cs sourcemaps. 
//
[assembly: JsExport(CodeInjectionFilename = "bin/sharp_core.js", 
                    DefaultFilenameAsCsFilename = true, 
                    FilenameFormat = "generated/demo/{0}", 
                    GenerateSourceMaps = false)]

// These are the default SharpKit code generation options for use with Randori
//
//      JsMode.Prototype - Generate all code in prototype mode
//      OmitCasts - When casting to one of your user defined classes, omit any code to perform that case... Js is typeless at runtime
//      NativeJsons - When create generic objects, use the Native Json format.
//
[assembly: JsType(JsMode.Prototype, OmitCasts = true, NativeJsons = true)]

// You may know that a certain series of classes needs to be loaded at startup. Or that they are commonly used by each user, so they should be loaded up front
// Here is your chance. You can specify any classes that are loaded by default on startup
//
//[assembly: JsMergedFile(Filename = "generated/initial_dependencies.js", Sources = new String[]{
//        "generated/Randori_Enterprise_Web_Application1/my/important/Class.js"
//    }, Minify = false)]


// Finally, you may want to cache individual HTML files in your project to be cached and available on startup. This is very useful for commonly used
// views or to make an offline app.
//
// The files listed below will be escaped and added to a class named HtmlMergedFile. The contents are then available for retieval via url in JavaScript
//
//[assembly: HtmlMergedFile(Filename = "generated/merged_fragments.js", Sources = new String[] {
//    "fragment/mergedFragment1.html",
//    "fragment/mergedFragment2.html"
//})]

