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

namespace HelloWorldXamariniOS
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnHello { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblHello { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtName { get; set; }

		[Action ("btnHello_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnHello_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnHello != null) {
				btnHello.Dispose ();
				btnHello = null;
			}
			if (lblHello != null) {
				lblHello.Dispose ();
				lblHello = null;
			}
			if (txtName != null) {
				txtName.Dispose ();
				txtName = null;
			}
		}
	}
}
