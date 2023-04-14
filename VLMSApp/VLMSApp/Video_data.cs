using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLMSApp
{
    internal class Video_data
    {
        public int video_id { get; set; }
        public string title { get; set; }
        public string director { get; set; }
        public int release_year { get; set; }
        public string genre { get; set; }
        public string summary { get; set; }
        public string actors { get; set; }
        public DateTime upload_datetime { get; set; }
        public int duration_minutes { get; set; }
        public double cost_dollars { get; set; }
        public string image_name { get; set; }


    }
}
