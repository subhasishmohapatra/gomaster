using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace TabbedApp
{
    [Activity(Label = "ChooseDocActivity")]
    public class ChooseDocActivity : Activity
    {
        RecyclerView recyclerView;
        RecyclerView.LayoutManager layoutManager;
        private WebClient mClient;
        private Uri mUrl;
        List<DocInfo> Info;
        private RecyclerAdapter mAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Choosedoc);
           
            //webclient start
            Info = new List<DocInfo>();
            mClient = new WebClient();
            mUrl = new Uri("http://thecybriainc-001-site32.itempurl.com/api/BmmDataFetch/GetFetchDoctordata/1");
            mClient.DownloadDataAsync(mUrl);
            mClient.DownloadDataCompleted += MClient_DownloadDataCompleted;

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
          

            layoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);

            recyclerView.SetLayoutManager(layoutManager);
            mAdapter = new RecyclerAdapter(Info, recyclerView);

            //mAdapter.ItemClick += MAdapter_ItemClick;
            //mAdapter.ItemClick += OnItemClick;
            mAdapter.ItemClick += OnItemClick;
            recyclerView.SetAdapter(mAdapter);
           

        }

     
        private void OnItemClick(object sender, int e)
        {
            throw new NotImplementedException();
        }

        //private void MAdapter_ItemClick(object sender, int e)
        //{
        //    var crewProfileIntent = new Intent(this, typeof(IconTextDataFragment));
        //    StartActivity(crewProfileIntent);
        //}

        //private void OnItemClick(object sender, int e)
        //{
        //    int photoNum = e + 1;
        //    var crewProfileIntent = new Intent(this, typeof(Activity1));
        //    StartActivity(crewProfileIntent);
        //}

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }


        private void MClient_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            RunOnUiThread(() =>
            {
                string json = System.Text.Encoding.UTF8.GetString(e.Result);
                Info = JsonConvert.DeserializeObject<List<DocInfo>>(json);
                foreach (var item in Info)
                {
                    item.ImagePath = "http://www.bookmymedic.com/" + item.ImagePath;
                    var Img = item.ImagePath;



                }
                recyclerView.SetAdapter(new RecyclerAdapter(Info,recyclerView));

            });
        }



    }
  

    }

