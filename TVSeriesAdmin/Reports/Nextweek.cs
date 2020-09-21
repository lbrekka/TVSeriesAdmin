using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVSeriesAdmin.DataAccess;
using TVSeriesAdmin.Models;

namespace TVSeriesAdmin.Reports
{
    public class Nextweek
    {
        readonly ITvMazeFetcher _service;

        public Nextweek(ITvMazeFetcher service)
        {
            _service = service;
        }
        public async Task<string> getNextweekReportAsync()
        {
            String reportstring = "SHOW_NAME;MONDAY;TUESDAY;WEDNESDAY;THURSDAY;FRIDAY;SATURDAY;SUNDAY";

            var tvShows = await _service.GetAllAsync();
            var l = tvShows.Where(show => show.Status != "Ended");

            return reportstring;
        }
    }
}
