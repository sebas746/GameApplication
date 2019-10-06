using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Entities.DTO;
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

        private IUnitOfWork unitOfWork;

        public StatisticsService(IGamingAppDAC GamingAppDAC, IUnitOfWork unitOfWork)
        {
            this._GamingAppDAC = GamingAppDAC;          
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<GameStatistics> GetStatistics()
        {
            return unitOfWork.GameStatistics.Get();
        }

        public GameStatistics GetStatistics(int id)
        {
            return unitOfWork.GameStatistics.GetByID(id);
        }


        public int InsertStatistics(GameStatistics gameStatistics)
        {
            gameStatistics.TimeStamp = DateTime.Now;
            unitOfWork.GameStatistics.Insert(gameStatistics);
            unitOfWork.Commit();
            return 1;
        }

        public IEnumerable<Ranking> GetTopPlayers()
        {
            return _GamingAppDAC.GetTopPlayers();
        }
    }
}
