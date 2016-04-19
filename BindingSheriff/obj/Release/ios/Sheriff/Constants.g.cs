//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Sheriff {
	public unsafe static partial class Constants  {
		
		[Field ("SheriffVersionNumber",  "__Internal")]
		public static unsafe global::System.Double SheriffVersionNumber {
			get {
				return Dlfcn.GetDouble (Libraries.__Internal.Handle, "SheriffVersionNumber");
			}
		}
		[CompilerGenerated]
		static NSString _SheriffVersionString;
		[Field ("SheriffVersionString",  "__Internal")]
		public static unsafe NSString SheriffVersionString {
			get {
				if (_SheriffVersionString == null)
					_SheriffVersionString = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "SheriffVersionString");
				return _SheriffVersionString;
			}
		}
	} /* class Constants */
}
