using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVSeriesAdmin.Models;

namespace TVSeriesAdmin.DataAccess
{
    interface ILocalDataContex
    {
        IEnumerable<T> GetTvShowNames();
    }
}
