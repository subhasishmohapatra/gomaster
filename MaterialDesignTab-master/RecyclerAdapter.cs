using Android.Support.V7.Widget;
using Android.Views;
using System;
using System.Collections.Generic;
using TabbedApp.Helper;

namespace TabbedApp
{
    public class RecyclerAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;


        private List<DocInfo> nInfo;

        private RecyclerView mRecyclerview;

        public RecyclerAdapter(List<DocInfo> Info,RecyclerView recyclerview)
        {
            nInfo = Info;
            mRecyclerview = recyclerview;
        }
        public override int ItemCount
        {
            get
            {
                return nInfo.Count;
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.DoctorsRecycleList, parent, false);

            //Create our ViewHolder to cache the layout view references and register
            //the OnClick event.
            Myview viewHolder = new Myview(itemView, OnClick);

            return viewHolder;
        }
        public override  void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            Myview myholder = holder as Myview;

            myholder.Name.Text = nInfo[position].HospitalName;
            myholder.DocName.Text = nInfo[position].Name;
            //myholder.mMainview.Click += MMainview_Click;


            myholder.ImageView1.SetImageBitmap(BusinessHelper.GetImageBitmapFromUrl(nInfo[position].ImagePath));
        }

        //private void MMainview_Click(object sender, EventArgs e)
        //{
        //   int positon = mRecyclerview.GetChildAdapterPosition((View)sender);
            
        //}

       

        private void OnClick(int position)
        {
            if (ItemClick != null)
            {
                ItemClick(this, position);
            }
        }
    }
}