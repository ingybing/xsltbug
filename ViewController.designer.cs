// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace xsltbug
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txtResult { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txtXml { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txtXslt { get; set; }

		[Action ("UIButton6_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton6_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (txtResult != null) {
				txtResult.Dispose ();
				txtResult = null;
			}
			if (txtXml != null) {
				txtXml.Dispose ();
				txtXml = null;
			}
			if (txtXslt != null) {
				txtXslt.Dispose ();
				txtXslt = null;
			}
		}
	}
}
