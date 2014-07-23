using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Community_Engagement_Application
{
	[Activity (Label = "Community Engagement Application", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it


			Button getinformationbtn = FindViewById<Button> (Resource.Id.getInformation);
			Button dataentrybtn = FindViewById<Button> (Resource.Id.dataEntry);


			
			getinformationbtn.Click += delegate
			{
				StartActivity(typeof(Data_Entry_Activity));
			};
			dataentrybtn.Click += delegate
			{
				StartActivity(typeof(Data_Entry_Activity));
			};

			
			

		}
	}
}


