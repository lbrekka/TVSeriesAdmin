using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TVSeriesAdmin.Models
{
    public class TvShow
    {
        public long? Id { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public String Type { get; set; }
        public String Language { get; set; }
        public List<String>? Genres { get; set; }
        public String Status { get; set; }
        public int? Runtime { get; set; }
        public String Premiered { get; set; }
        public String Officialsite { get; set; }
        public Schedule? Schedule { get; set; }
        public Rating? Rating { get; set; }
        public int? Weight { get; set; }
        public Network? Network { get; set; }
        public Webchannel? Webchannel { get; set; }
        public Externals? Externals { get; set; }
        public Image? Image { get; set; }
        public String? Summary { get; set; }
        public int Updated { get; set; }
        public Links? Links { get; set; }
    }
}
