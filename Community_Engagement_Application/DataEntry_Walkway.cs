
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Community_Engagement_Application
{
	[Activity (Label = "DataEntry_Walkway")]			
	public class DataEntry_Walkway : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.DataEntry_Walkway);
			// Create your application here
		}
	}
}

