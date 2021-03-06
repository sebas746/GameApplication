﻿using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.Interfaces.Service
{
    public interface IStatisticsService
    {
        IEnumerable<GameStatistics> GetStatistics();
        GameStatistics GetStatistics(int id);
        int InsertStatistics(GameStatistics gameStatistics);
        IEnumerable<Ranking> GetTopPlayers();
    }
}
