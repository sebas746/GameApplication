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
            var response = _IStatisticsService.GetAll();
            return response;
        }
    }
}
