using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TVSeriesAdmin.Models;

namespace TVSeriesAdmin.DataAccess
{
    public class LocalDataContext : ILocalDataContex
    {
        public IEnumerable<TvShowName> GetTvShowNames()
        {
            var names = new List<TvShowName>();
            var fileName = Environment.CurrentDirectory + @"\Vedlegg.txt";
            var lines = File.ReadLines(fileName);
            foreach (var line in lines)
            {
                var tvShowName = new TvShowName { Name = line };
                names.Add(tvShowName);
            }

            return names;
        }
    }
}
