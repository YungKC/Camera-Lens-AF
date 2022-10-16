using System.Reflection;
using System.Runtime.InteropServices;

// [MANDATORY] The following GUID is used as a unique identifier of the plugin
[assembly: Guid("945B66BB-9D4B-4A41-9693-E336DA51A102")]

// [MANDATORY] The assembly versioning
//Should be incremented for each new release build of a plugin
[assembly: AssemblyVersion("0.1")]
[assembly: AssemblyFileVersion("0.1")]

// [MANDATORY] The name of your plugin
[assembly: AssemblyTitle("Kai_Lens_AF")]
// [MANDATORY] A short description of your plugin
[assembly: AssemblyDescription("Kai's fork of Christian Palm's Camera Lens AF")]

// Your name
[assembly: AssemblyCompany("Kai Yung")]
// The product name that this plugin is part of
[assembly: AssemblyProduct("Kai's Camera Lens AF")]
[assembly: AssemblyCopyright("Copyright ©  2022")]

// The minimum Version of N.I.N.A. that this plugin is compatible with
[assembly: AssemblyMetadata("MinimumApplicationVersion", "2.0.0.2054")]

// The license your plugin code is using
[assembly: AssemblyMetadata("License", "MPL-2.0")]
// The url to the license
[assembly: AssemblyMetadata("LicenseURL", "https://www.mozilla.org/en-US/MPL/2.0/")]
[assembly: AssemblyMetadata("Repository", "https://github.com/YungKC/Camera-Lens-AF.git")]


// The following attributes are optional for the official manifest meta data

//[Optional] Common tags that quickly describe your plugin
[assembly: AssemblyMetadata("Tags", "AF,Sequencer,Canon")]

//[Optional] An in-depth description of your plugin
[assembly: AssemblyMetadata("LongDescription", @"This Plugin provides an instruction and triggers for the Advanced to run an AF with your camera lens attached to a Canon Camera

## Important Note!
**Test the plugin before you use it in your imaging runs, because this plugin may not work for everyone! This plugin doesn't work with ASCOM.DSLR unfortuantely!**  
If you have questions/feedback/issues, you can ask on the [NINA discord](https://discord.com/invite/nighttime-imaging) in #plugin-discussions, take a look in the [wiki](https://github.com/rennmaus-coder/Camera-Lens-AF/wiki) or create an issue [here](https://github.com/rennmaus-coder/Camera-Lens-AF/issues)


**Requirements**:  
- A Canon Camera,  
- A Camera Lens that supports AF
- The plugin only runs in the advanced sequencer and the imaging tab

The plugin was tested using the following camera and lenses:
- Canon EOS 600d
- Canon EF 100-400 f/4.5-5.6 L IS USM
- Canon EF 24-105 f/4 L IS USM

## Manual Focus Control controls
- Mousewheel/Trackpad: Zoom in/out
- Left mousebutton: Pan around
- Right mousebutton: reset


Known issues:
- Some cameras or lenses may try to refocus, when taking images if the lens is set to AF




#Troubleshooting:
What to try if:
- ...the focus doesn't move: Try a different step size (2 always worked for me) or try switching your lens from AF/MF to MF/AF
- ...the plugin didn't result in good focus: Try a different step size (2 always worked for me)")]


// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]
// [Unused]
[assembly: AssemblyConfiguration("")]
// [Unused]
[assembly: AssemblyTrademark("")]
// [Unused]
[assembly: AssemblyCulture("")]