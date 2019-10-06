using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Interfaces.DAC;
using System.Collections.Generic;
using System.Linq;

namespace GamingApp.DAC.DataAccess.GamingApp
{
    public class GamingAppDAC : IGamingAppDAC
    {
        public List<GameStatistics> GetAll()
        {
            using (GamingAppDataContext db = new GamingAppDataContext())
            {
                return db.GameStatistics.ToList();
            }
        }

        public int InsertGameStatistics(GameStatistics gameStatistics)
        {
            using (GamingAppDataContext db = new GamingAppDataContext())
            {
                db.GameStatistics.Add(gameStatistics);
                var result = db.SaveChanges();
                return result;
            }
        }
    }
}
