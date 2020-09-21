using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TVSeriesAdmin.Models;

namespace TVSeriesAdmin.DataAccess
{
    public class TvMazeFetcher : ITvMazeFetcher
    {
        private const string BaseUrl = "http://api.tvmaze.com/";
        private readonly HttpClient _client;

        readonly ILocalDataContext _localdata;

        public TvMazeFetcher(ILocalDataContext localdata, HttpClient client)
        {
            _localdata = localdata;
            _client = client;
        }

        public async Task<List<TvShowForTable>> GetAllAsync()
        {
            string query = "/singlesearch/shows?q=";
            var shows = new List<TvShowForTable>();
            String content;
            TvShowForTable show;

            foreach (TvShowName tvShowName in _localdata.GetTvShowNames())
            {
                var name = tvShowName.Name;
                

                int i = 0;

                while (i < 10)
                {
                    var httpResponse = await _client.GetAsync($"{BaseUrl}{query}{name}");
                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        // todo: må ha ny httpRespinse
                        await Task.Delay(1000);
                        i++;
                    }
                    else
                    {
                        content = await httpResponse.Content.ReadAsStringAsync();
                        show = JsonConvert.DeserializeObject<TvShowForTable>(content);
                        shows.Add(show);
                        break;
                    }
                }
            }
            return shows;
        }

        public async Task<EpisodeByDate> GetEpisodeByDate(DateTime date, int id)
        {
            string query = $"/shows/{id}/episodesbydate?date={date}";
            var httpResponse = await _client.GetAsync($"{BaseUrl}{query}");
            var content = await httpResponse.Content.ReadAsStringAsync();
            var episode = JsonConvert.DeserializeObject<EpisodeByDate>(content);

            return episode;
        }
    }
}
