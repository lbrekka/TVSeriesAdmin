using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVSeriesAdmin.Models
{
    public class Links
    {
        public Self? Self { get; set; }
        public Previousepisode? Previousepisode { get; set; }
        public Nextepisode? Nextepisode { get; set; }
    }
}