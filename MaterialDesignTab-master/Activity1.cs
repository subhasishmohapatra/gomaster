using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using support = Android.Support.V4.App.Fragment;
using TabbedApp.AndroidSession;
namespace TabbedApp
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        private List<string> nitems;
        private ListView mListView;
 

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layout1);
            mListView = FindViewById<ListView>(Resource.Id.MyListView);
                nitems = new List<string>();
            nitems.Add("Dentist");
            nitems.Add("Psychatrist");
            nitems.Add("D0octor");
            nitems.Add("Dentist");
            nitems.Add("Psychatrist");
            nitems.Add("Dentist");
            nitems.Add("Psychatrist");
            nitems.Add("D0octor");
            nitems.Add("D0octor");
            CustomListAdapter adapter = new CustomListAdapter(this,nitems);
            mListView.Adapter = adapter;
            mListView.ItemClick += MListView_ItemClick;


            //Intent resultIntent = new Intent();
            //resultIntent.PutExtra("extra", "put anything");
            //SetResult(Result.Ok, resultIntent);
            //StartActivityForResult(resultIntent, 0);



        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            SessionManager.DocDropDownValue = Convert.ToString(this.mListView.GetItemAtPosition(e.Position));
            var item = Convert.ToString(this.mListView.GetItemAtPosition(e.Position));
            var activity2 = new Intent(this, typeof(IconTabActivity));
            activity2.PutExtra("MyData", item);
            StartActivity(activity2);
        }
    }
   
}