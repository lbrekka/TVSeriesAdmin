using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TVSeriesAdmin.Models
{
    public class TvShowForTable
    {
        public long? Id { get; set; }
        public String Name { get; set; }
        public String Url { get; set; }
        public String Type { get; set; }
        public String Language { get; set; }
        public String Status { get; set; }
        public int? Runtime { get; set; }
        public String Premiered { get; set; }
        public String Officialsite { get; set; }
        public int? Weight { get; set; }
        public int Updated { get; set; }
    }
}
