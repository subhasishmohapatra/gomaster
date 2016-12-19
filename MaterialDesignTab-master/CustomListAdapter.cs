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
      class CustomListAdapter : BaseAdapter<string>
    {
        private List<string> nitems;
        private Context mContext;

        public CustomListAdapter(Context context, List<string>items)
        {
            nitems = items;
            mContext = context;

        }

        public override string this[int position]
        {
            get
            {
                return nitems[position];
            }
        }

        public override int Count
        {
            get
            {
                return nitems.Count;
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
                view = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListItemRow, null,false);

            }
            TextView txtDocCategory = view.FindViewById<TextView>(Resource.Id.TxtDocCategory);
            txtDocCategory.Text = nitems[position];
            
            return view;
        }

    }

}