using GamingApp.Domain.DataContext.GamingApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.Interfaces.DAC
{
    public interface IUnitOfWork
    {
        IRepository<GameStatistics> GameStatistics { get; }       
        void Commit();
    }
}
