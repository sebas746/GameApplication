using GamingApp.Domain.DataContext.GamingApp;
using System.Collections.Generic;

namespace GamingApp.Domain.Interfaces.DAC
{
    public interface IGamingAppDAC
    {
        List<GameStatistics> GetAll();
        int InsertGameStatistics(GameStatistics gameStatistics);
    }
}
