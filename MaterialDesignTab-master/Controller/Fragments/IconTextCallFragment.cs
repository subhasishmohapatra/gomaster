
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Support = Android.Support.V4.App.Fragment;
using TabbedApp.AndroidSession;

namespace TabbedApp
{
    public class IconTextCallFragment : Android.Support.V4.App.Fragment
    {
        private TextView Textview;


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Intent intent = new Intent(this, typeof(IconTabActivity));
            //    startActivityForResult(intent, 1);

    }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
           
            

            // Use this to return your custom view for this Fragment 
            View view = inflater.Inflate(Resource.Layout.IconTxtCallLayout, container, false);
            Textview = view.FindViewById<TextView>(Resource.Id.clickable_text_view);
            var textView1 = view.FindViewById<TextView>(Resource.Id.clickable_text_view);
            var bookbutton = view.FindViewById<Button>(Resource.Id.book_button);
            bookbutton.Click += Bookbutton_Click;
            Textview.Click += StartNewActivity;

            if (!string.IsNullOrEmpty(SessionManager.DocDropDownValue))
            {
                Textview.Text = SessionManager.DocDropDownValue;
            }
            else
            {
                // select dropdown value
                SessionManager.DocDropDownValue = string.Empty;
            }
            //String strtext = Arguments.GetString("edttext");
            return view;

        }

        private void Bookbutton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this.Activity, typeof(ChooseDocActivity));
            this.StartActivity(intent);
        }

        private void StartNewActivity(object sender, EventArgs e)
        {

            Intent intent = new Intent(this.Activity, typeof(Activity1));
            this.StartActivity(intent);
            Activity.OverridePendingTransition(Resource.Animation.BounceTop, Resource.Animation.Slide_out);


        }
       
    }
}


    