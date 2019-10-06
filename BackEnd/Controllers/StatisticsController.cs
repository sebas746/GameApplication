using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GamingAppBackEnd.Controllers
{
    public class StatisticsController : ApiController
    {
        public IStatisticsService _IStatisticsService;

        public StatisticsController(IStatisticsService IStatisticsService)
        {
            this._IStatisticsService = IStatisticsService;
        }

        //// GET api/<controller>
        [HttpGet]
        public IEnumerable<GameStatistics> GetStatistics()
        {
            var response = _IStatisticsService.GetStatistics();
            return response;
        }

        [HttpGet]
        public GameStatistics GetStatistics(int id)
        {
            var response = _IStatisticsService.GetStatistics(id);
            return response;
        }

        [HttpPost]
        public IHttpActionResult CreateStatistics(GameStatistics statistics)
        {
            var response = _IStatisticsService.InsertStatistics(statistics);
            return Ok(response);
        }
    }
}
