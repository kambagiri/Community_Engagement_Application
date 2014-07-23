
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
	[Activity (Label = "Community Engagement Application")]			
	public class Data_Entry_Activity : Activity
	{
		DateTime _date;
		string getOOIitem;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.DataEntry_Introduction);

			Button continuebtn = FindViewById<Button> (Resource.Id.Continue);
			var dateText = FindViewById<EditText> (Resource.Id.datePickerText);

			dateText.Click += delegate {
				ShowDialog(0);
			};

			_date = DateTime.Today;
			dateText.Text = _date.ToString ("d");

			Spinner spinner = FindViewById<Spinner> (Resource.Id.spinner);

			spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
			var adapter = ArrayAdapter.CreateFromResource (
				this, Resource.Array.Object_Of_Interest,Android.Resource.Layout.SimpleSpinnerItem);
			adapter.SetDropDownViewResource (Android.Resource.Layout.SimpleSpinnerDropDownItem);
			spinner.Adapter = adapter;

		
			continuebtn.Click += delegate
			{
				switch (getOOIitem) {
				case("Intersection"): StartActivity(typeof(DataEntry_Intersection));
					break;
				case("Traffic Light"): StartActivity(typeof(DataEntry_TrafficLight));
					break;
				case("WalkWay"): StartActivity(typeof(DataEntry_Walkway));
					break;
				case("Shops"): StartActivity(typeof(DataEntry_Shop));
					break;

				default: //pop-up needs to build.
						break;
							}
			};
				
			var autocompleteoptions = new string[]{"Jagriti","Liji","Limi","Reji"};
			ArrayAdapter namesAdapter = new ArrayAdapter (this, Android.Resource.Layout.SimpleDropDownItem1Line, autocompleteoptions);
			var autocompleteTextView = FindViewById<AutoCompleteTextView> (Resource.Id.AutoCompleteInput);
			autocompleteTextView.Adapter = namesAdapter;
		}

		protected override Dialog OnCreateDialog (int id)
		{
			return new DatePickerDialog (this, HandleDateSet, _date.Year, _date.Month - 1, _date.Day); 
		}

		void HandleDateSet (object sender, DatePickerDialog.DateSetEventArgs e)
		{
			_date = e.Date;

			var dateText = FindViewById<EditText> (Resource.Id.datePickerText);
			dateText.Text = _date.ToString ("d");
		}

		private void spinner_ItemSelected(object sender,AdapterView.ItemSelectedEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
			getOOIitem = (string)spinner.GetItemAtPosition (e.Position);
			//string toast = string.Format ("Object Of Interest selected is {0}", spinner.GetItemAtPosition (e.Position));
			//Toast.MakeText (this, toast, ToastLength.Long).Show ();
		}
	}
}

