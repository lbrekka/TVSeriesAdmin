using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVSeriesAdmin.Models
{
    public class Schedule
    {
        public string Time { get; set; }
        public IList<String>? Days { get; set; }

    }
}
