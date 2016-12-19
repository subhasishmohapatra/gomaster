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

namespace TabbedApp
{
    class DoctorListAdapter : BaseAdapter<Doctor>
    {
        private readonly Activity mcontext;
        private readonly List<Doctor> mDoctor;


        public DoctorListAdapter(Activity context, List<Doctor> mDoctor)
        {
            this.mcontext = context;
            this.mDoctor = mDoctor;


        }

        public override Doctor this[int position]
        {
            get
            {
                return mDoctor[position];
            }
        }

        public override int Count
        {
            get
            {
                return mDoctor.Count;

            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
            {
                view = mcontext.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);

            }
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = mDoctor[position].Name;
            return view;
        }
    }
}