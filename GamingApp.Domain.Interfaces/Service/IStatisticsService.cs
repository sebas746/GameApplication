using GamingApp.Domain.DataContext.GamingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.Interfaces.Service
{
    public interface IStatisticsService
    {
        List<GameStatistics> GetAll();
        int InsertGameStatistics(GameStatistics gameStatistics);
    }
}
