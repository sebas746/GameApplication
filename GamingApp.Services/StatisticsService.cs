using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Interfaces.DAC;
using GamingApp.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Services
{
    public class StatisticsService : IStatisticsService
    {
        private IGamingAppDAC _GamingAppDAC { get; set; }

        public StatisticsService(IGamingAppDAC GamingAppDAC)
        {
            this._GamingAppDAC = GamingAppDAC;
        }

        public List<GameStatistics> GetAll()
        {
            return _GamingAppDAC.GetAll();
        }

        public int InsertGameStatistics(GameStatistics gameStatistics)
        {
            gameStatistics.TimeStamp = DateTime.Now;
            return _GamingAppDAC.InsertGameStatistics(gameStatistics);
        }
    }
}
