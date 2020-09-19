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

        public async Task<List<TvShow>> GetAllAsync()
        {
            string query = "/singlesearch/shows?q=";
            var shows = new List<TvShow>();
            String content;
            TvShow show;

            foreach (TvShowName tvShowName in _localdata.GetTvShowNames())
            {
                var name = tvShowName.Name;
                var httpResponse = await _client.GetAsync($"{BaseUrl}{query}{name}");

                int i = 0;

                while (i < 10)
                {
                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        await Task.Delay(1000);
                        i++;
                    }
                    else
                    {
                        content = await httpResponse.Content.ReadAsStringAsync();
                        show = JsonConvert.DeserializeObject<TvShow>(content);
                        shows.Add(show);
                        break;
                    }
                }
            }
            return shows;
        }
    }
}
