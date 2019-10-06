using System;
using System.Collections.Generic;
using GamingApp.DAC.DataAccess;
using GamingApp.Domain.DataContext.GamingApp;
using GamingApp.Domain.Interfaces.DAC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using GamingApp.DAC.DataAccess.GamingApp;
using GamingApp.Domain.Entities.DTO;

namespace GamingApp.Dac.Test
{
    [TestClass]
    public class GamingAppTest
    {
        private IUnitOfWork _UnitofWork;
        private IGamingAppDAC _GamingAppDAC;
        private GamingAppDataContext dbContext; 

        [TestInitialize]
        public void Init()
        {
            dbContext = new GamingAppDataContext();
            _UnitofWork = new UnitOfWork(dbContext);
            _GamingAppDAC = new GamingAppDAC();
        }
        

        [TestMethod]
        public void GetStatisticsTest()
        {
            //Arrange
            IEnumerable<GameStatistics> response; 

            //Act
            response = _UnitofWork.GameStatistics.Get();


            //Asserts
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count() > 0);
        }

        [TestMethod]
        public void GetRankingTest()
        {
            //Arrange
            IEnumerable<Ranking> response;

            //Act
            response = _GamingAppDAC.GetTopPlayers();


            //Asserts
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Count() > 0);
        }
    }
}
