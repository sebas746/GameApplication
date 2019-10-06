using GamingApp.Domain.DataContext.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp.Domain.DataContext.GamingApp
{
    public partial class GamingAppDataContext : DbContext
    {
        public GamingAppDataContext() : base("name=GamingAppDataContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GamingAppDataContext, Configuration>());
        }

        public virtual DbSet<GameStatistics> GameStatistics { get; set; }
    }
}
