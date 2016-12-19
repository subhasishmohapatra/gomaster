﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace TabbedApp
{
	[Activity (Label = "Book My Medic",MainLauncher=true)]			
	public class IconTabActivity : AppCompatActivity
	{
		TabLayout tabLayout;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.CustomIconTabLayout); 
			var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.app_bar);
          

            SetSupportActionBar (toolbar);
			//SupportActionBar.SetDisplayHomeAsUpEnabled (true);
     
 
			tabLayout=FindViewById<TabLayout>(Resource.Id.sliding_tabsIcon);  
			FnInitTabLayout ();

            string text = Intent.GetStringExtra("MyData") ?? "Data not available";

            Intent returnIntent = new Intent();
            returnIntent.PutExtra("result", text);
            SetResult(Result.Ok, returnIntent);
     

        


    }

      

        void FnInitTabLayout()
		{
			tabLayout.SetTabTextColors (Android.Graphics.Color.Aqua,Android.Graphics.Color.AntiqueWhite);
			//Fragment array
			var fragments = new Android.Support.V4.App.Fragment[]
			{ 
				new IconTextCallFragment(),
				
				new IconTextDataFragment(), 
			};  
			//Tab title array
			var titles = CharSequence.ArrayFromStringArray (new[] { 
				GetString(Resource.String.strCall),
				
				GetString(Resource.String.strData), 
			});
			var viewPager = FindViewById<ViewPager>(Resource.Id.viewpagerIcon);
			//viewpager holding fragment array and tab title text
			viewPager.Adapter = new TabsFragmentPagerAdapter(SupportFragmentManager, fragments,titles);

			// Give the TabLayout the ViewPager 
			tabLayout.SetupWithViewPager(viewPager); 
			//tabLayout.SetTabTextColors(
			FnSetIcons();
			//FnSetupTabIconsWithText ();
		} 
		void FnSetIcons()
		{ 
			tabLayout.GetTabAt (0).SetIcon (Resource.Drawable.iconCall);
		
			tabLayout.GetTabAt (1).SetIcon (Resource.Drawable.iconData); 
		}

		private void FnSetupTabIconsWithText () {
			View view =  LayoutInflater.Inflate (Resource.Layout.custom_text, null); 
			var custTabOne = view.FindViewById<TextView> (Resource.Id.txtTabText);
			custTabOne.Text=GetString(Resource.String.strCall);
           
            custTabOne.SetCompoundDrawablesWithIntrinsicBounds( Resource.Drawable.ic_call,0, 0, 0);
			tabLayout.GetTabAt(0).SetCustomView(custTabOne);

	

			View view2 =  LayoutInflater.Inflate (Resource.Layout.custom_text, null); 
			TextView custTabThree = view2.FindViewById<TextView> (Resource.Id.txtTabText);//(TextView)LayoutInflater.Inflate (Resource.Layout.custom_text, null); ;
			custTabThree.Text=GetString(Resource.String.strData);
           
            custTabThree.SetCompoundDrawablesWithIntrinsicBounds( Resource.Drawable.ic_wifi,0, 0, 0);
			tabLayout.GetTabAt(1).SetCustomView(custTabThree);
		} 

	}
}

