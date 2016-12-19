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
   
        public class DocInfo
        {
            public int DocInfoId { get; set; }
            public string Qualification { get; set; }
            public string Specialization { get; set; }
            public string AreaName { get; set; }
            public string Name { get; set; }
            public string HospitalName { get; set; }
            public int WorkExp { get; set; }
            public int Fee { get; set; }
            public int ImageId { get; set; }
            public string ImagePath { get; set; }

            public DocInfo(int docInfoId, string doctorName, string hospitalName, int workExp, int fee, int imageId, string qualification, string Specialization, string areaname, string ImagePath)
            {
                this.AreaName = areaname;
                this.Specialization = Specialization;
                this.Qualification = qualification;
                this.Name = doctorName;
                this.HospitalName = hospitalName;
                this.WorkExp = workExp;
                this.Fee = fee;
                this.ImageId = imageId;
                this.ImagePath = ImagePath;
            }
        }
    }
