using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVSeriesAdmin.Models
{
    public class Webchannel {
        public long Id { get; set; }
        public String Name { get; set; }
        public Country? Country { get; set; }
    
    }
}
