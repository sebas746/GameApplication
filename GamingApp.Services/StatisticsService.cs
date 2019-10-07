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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IGamingAppDAC _GamingAppDAC { get; set; }

        private IUnitOfWork unitOfWork;

        public StatisticsService(IGamingAppDAC GamingAppDAC, IUnitOfWork unitOfWork)
        {
            this._GamingAppDAC = GamingAppDAC;          
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<GameStatistics> GetStatistics()
        {
            try
            {
                return unitOfWork.GameStatistics.Get();
            }
            catch(Exception exc)
            {
                log.Error(exc.Message);
                log.Error(exc.InnerException.Message);
                throw exc;
            }
        }

        public GameStatistics GetStatistics(int id)
        {
            try
            {
                return unitOfWork.GameStatistics.GetByID(id);
            }            
            catch (Exception exc)
            {
                log.Error(exc.Message);
                log.Error(exc.InnerException.Message);
                throw exc;
            }
        }


        public int InsertStatistics(GameStatistics gameStatistics)
        {
            try
            {
                gameStatistics.TimeStamp = DateTime.Now;
                unitOfWork.GameStatistics.Insert(gameStatistics);
                unitOfWork.Commit();
                return 1;
            }
            catch (Exception exc)
            {
                log.Error(exc.Message);
                log.Error(exc.InnerException.Message);
                throw exc;
            }
        }

        public IEnumerable<Ranking> GetTopPlayers()
        {
            try
            {
                return _GamingAppDAC.GetTopPlayers();
            }
            catch (Exception exc)
            {
                log.Error(exc.Message);
                log.Error(exc.InnerException.Message);
                throw exc;
            }
        }
    }
}
