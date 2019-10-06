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
        private IRepository<GameStatistics> _repository { get; set; }

        public StatisticsService(IGamingAppDAC GamingAppDAC, IRepository<GameStatistics> repository)
        {
            this._GamingAppDAC = GamingAppDAC;
            this._repository = repository;
        }

        public IEnumerable<GameStatistics> GetStatistics()
        {
            return _repository.Get();
        }

        public GameStatistics GetStatistics(int id)
        {
            return _repository.GetByID(id);
        }

        public int InsertGameStatistics(GameStatistics gameStatistics)
        {
            gameStatistics.TimeStamp = DateTime.Now;
            return _GamingAppDAC.InsertGameStatistics(gameStatistics);
        }
    }
}
