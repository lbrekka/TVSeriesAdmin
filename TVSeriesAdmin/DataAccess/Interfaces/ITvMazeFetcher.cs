using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVSeriesAdmin.Models;

namespace TVSeriesAdmin.DataAccess
{
    public interface ITvMazeFetcher
    {
        Task<List<TvShowForTable>> GetAllAsync();
        Task<EpisodeByDate> GetEpisodeByDate(DateTime date, int id);
        Task<String> GetHttpResponse(String url);
    }
}
