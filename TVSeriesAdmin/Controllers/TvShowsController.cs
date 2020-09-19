using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TVSeriesAdmin.DataAccess;

namespace TVSeriesAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvShowsController : ControllerBase
    {
        readonly ITvMazeFetcher _service;

        public TvShowsController(ITvMazeFetcher service)
        {
            _service = service;
        }

        [HttpGet]
        // GET: api/TvShows
        public async Task<IActionResult> GetAllTvShows()
        {
            var tvShows = await _service.GetAllAsync();

            return Ok(tvShows);
        }

    }
}