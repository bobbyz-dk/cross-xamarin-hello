using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ClassLibrary1;

namespace HelloWorldXamarinAndroid
{
	[Activity(Label = "HelloWorldXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		Shared lib;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			lib = new Shared();

			TextView lblHello = FindViewById<TextView>(Resource.Id.lblHello);
			EditText txtName = FindViewById<EditText>(Resource.Id.txtName);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btnHello = FindViewById<Button>(Resource.Id.btnHello);

			btnHello.Click += delegate { lblHello.Text = lib.hello(txtName.Text); };
		}
	}
}

