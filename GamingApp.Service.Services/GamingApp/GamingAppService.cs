using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Interfaces.DAC;
using GamingApp.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.Service.Services
{
    class GamingAppService : IGamingAppService
    {
        private IGamingAppDAC _GaminAppDAC { get; set; }

        public GamingAppService(IGamingAppDAC GaminAppDAC)
        {
            this._GaminAppDAC = GaminAppDAC;
        }

        public List<GameStatistics> GetAll()
        {
            return _GaminAppDAC.GetAll();
        }

        public int InsertGameStatistics(GameStatistics gameStatistics)
        {
            gameStatistics.TimeStamp = DateTime.Now;
            return _GaminAppDAC.InsertGameStatistics(gameStatistics);
        }
    }
}
