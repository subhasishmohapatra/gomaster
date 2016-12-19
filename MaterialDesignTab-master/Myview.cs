using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System;

namespace TabbedApp
{
    public class Myview : RecyclerView.ViewHolder
    {
        public View mMainview { get; set; }
        public ImageView ImageView1 { get; set; }
        public ImageView ImageView2 { get; set; }
        public TextView Name { get; set; }
        public TextView DocName { get; set; }
        public TextView Fee { get; set; }
        public TextView WorkExp { get; set; }
        public String ImagePath { get; set; }
       


        public Myview(View itemView, Action<int> ItemClick)
           : base(itemView)
        {
            ImageView1 = itemView.FindViewById<ImageView>(Resource.Id.list_image);
            Name = itemView.FindViewById<TextView>(Resource.Id.Price);
            DocName = itemView.FindViewById<TextView>(Resource.Id.Name);
            //var card = DoctorsRecycleList.FindViewById<TextView>(Resource.Id.card_view);
            mMainview = itemView;
             Fee = itemView.FindViewById<TextView>(Resource.Id.total);
             WorkExp = itemView.FindViewById<TextView>(Resource.Id.tv_quantity);
            
            itemView.Click += (sender, e) => ItemClick(AdapterPosition);

        }

        
    }
}