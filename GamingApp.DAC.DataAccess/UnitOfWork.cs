using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Interfaces.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.DAC.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private GamingAppDataContext _dbContext;
        private BaseRepository<GameStatistics> _gameStatistics;

        public UnitOfWork(GamingAppDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<GameStatistics> GameStatistics
        {
            get
            {
                return _gameStatistics ??
                    (_gameStatistics = new BaseRepository<GameStatistics>(_dbContext));
            }
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
