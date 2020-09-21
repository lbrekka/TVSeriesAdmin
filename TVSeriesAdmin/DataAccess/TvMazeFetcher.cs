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
            TvShowForTable show;

            foreach (TvShowName tvShowName in _localdata.GetTvShowNames())
            {
                var name = tvShowName.Name;
                var httpResponse = await GetHttpResponse($"{BaseUrl}{query}{name}");
                show = JsonConvert.DeserializeObject<TvShowForTable>(httpResponse);
                shows.Add(show);

            }
            return shows;
        }

        public async Task<EpisodeByDate> GetEpisodeByDate(DateTime date, int id)
        {
            string query = $"/shows/{id}/episodesbydate?date={date}";
            var httpResponse = await GetHttpResponse($"{BaseUrl}{query}");
            var episode = JsonConvert.DeserializeObject<EpisodeByDate>(httpResponse);

            return episode;
        }

        public async Task<String> GetHttpResponse(String url)
        {
            String content = "";
            int i = 0;
            while (i < 10)
            {
                var httpResponse = await _client.GetAsync(url);
                if (!httpResponse.IsSuccessStatusCode)
                {
                    await Task.Delay(1000);
                    i++;
                    if (i == 10)
                    {
                        throw new Exception("Could not get content");
                    }
                }
                else
                {
                    content = await httpResponse.Content.ReadAsStringAsync();

                    break;
                }
            }
            return content;
        }
    }
}
