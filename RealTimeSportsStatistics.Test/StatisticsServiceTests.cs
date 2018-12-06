using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealTimeSportsStatistics.Shared.Services;
using RealTimeSportsStatistics.Shared.Services.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeSportsStatistics.Test
{
    [TestClass]
    public class StatisticsServiceTests
    {
        private readonly AutoMoqer _mocker1 = new AutoMoqer();

        [TestInitialize]
        public void Initialize()
        {
            _mocker1.GetMock<IExistingStatisticsService>()
                       .Setup(x => x.ExistingTeam1Id())
                       .Returns(9);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1AverageYardsPerPunt())
                    .Returns(45);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalFirstDowns())
                    .Returns(20);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalFumbles())
                    .Returns(3);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalFumblesLost())
                    .Returns(1);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalNumberOfPenalties())
                    .Returns(9);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalNumberOfPunts())
                    .Returns(5);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalPassesAttempted())
                    .Returns(35);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalPassesCompleted())
                    .Returns(25);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalPassesIntercepted())
                    .Returns(1);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalPassingYards())
                    .Returns(300);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalPenaltyYards())
                    .Returns(75);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalRushes())
                    .Returns(25);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalRushingYards())
                    .Returns(150);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalSacks())
                    .Returns(3);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalSackYardsLost())
                    .Returns(50);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalScore())
                    .Returns(28);
            _mocker1.GetMock<IExistingStatisticsService>()
                    .Setup(x => x.ExistingTeam1TotalYards())
                    .Returns(450);
        }

        [TestMethod]
        public void Team1Id_IsTeam1Id9_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1Id = statisticsService.IsTeam1Id9(statistics);
            Assert.AreEqual(9, Team1Id);
        }

        [TestMethod]
        public void Team1Id_IsNotTeam1Id9_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1Id = statisticsService.IsTeam1Id9(statistics);
            Assert.AreNotEqual(8, Team1Id);
        }

        [TestMethod]
        public void Team1TotalYards_IsTeam1TotalYards450_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalYards = statisticsService.IsTeam1TotalYards450(statistics);
            Assert.AreEqual(450, Team1TotalYards);
        }

        [TestMethod]
        public void Team1TotalYards_IsNotTeam1TotalYards450_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalYards = statisticsService.IsTeam1TotalYards450(statistics);
            Assert.AreNotEqual(425, Team1TotalYards);
        }

        [TestMethod]
        public void Team1AverageYardsPerPunt_IsTeam1AverageYardsPerPunt45_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1AverageYardsPerPunt = statisticsService.IsTeam1AverageYardsPerPunt45(statistics);
            Assert.AreEqual(45, Team1AverageYardsPerPunt);
        }

        [TestMethod]
        public void Team1AverageYardsPerPunt_IsNotTeam1AverageYardsPerPunt45_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1AverageYardsPerPunt = statisticsService.IsTeam1AverageYardsPerPunt45(statistics);
            Assert.AreNotEqual(44, Team1AverageYardsPerPunt);
        }

        [TestMethod]
        public void Team1TotalFirstDowns_IsTeam1TotalFirstowns20_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalFirstDowns = statisticsService.IsTeam1TotalFirstDowns20(statistics);
            Assert.AreEqual(20, Team1TotalFirstDowns);
        }

        [TestMethod]
        public void Team1TotalFirstDowns_IsNotTeam1TotalFirstowns20_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalFirstDowns = statisticsService.IsTeam1TotalFirstDowns20(statistics);
            Assert.AreNotEqual(18, Team1TotalFirstDowns);
        }

        [TestMethod]
        public void Team1TotalFumbles_IsTeam1TotalFumbles3_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalFumbles = statisticsService.IsTeam1TotalFumbles3(statistics);
            Assert.AreEqual(3, Team1TotalFumbles);
        }

        [TestMethod]
        public void Team1TotalFumbles_IsNotTeam1TotalFumbles3_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalFumbles = statisticsService.IsTeam1TotalFumbles3(statistics);
            Assert.AreNotEqual(2, Team1TotalFumbles);
        }

        [TestMethod]
        public void Team1TotalNumberOfPenalties_IsTeam1TotalNumberOfPenalties9_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalNumberOfPenalties = statisticsService.IsTeam1TotalNumberOfPenalties9(statistics);
            Assert.AreEqual(9, Team1TotalNumberOfPenalties);
        }

        [TestMethod]
        public void Team1TotalNumberOfPenalties_IsNotTeam1TotalNumberOfPenalties9_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalNumberOfPenalties = statisticsService.IsTeam1TotalNumberOfPenalties9(statistics);
            Assert.AreNotEqual(8, Team1TotalNumberOfPenalties);
        }

        [TestMethod]
        public void Team1TotalNumberOfPunts_IsTeam1TotalNumberOfPunts5_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalNumberOfPunts = statisticsService.IsTeam1TotalNumberOfPunts5(statistics);
            Assert.AreEqual(5, Team1TotalNumberOfPunts);
        }

        [TestMethod]
        public void Team1TotalNumberOfPunts_IsNotTeam1TotalNumberOfPunts5_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalNumberOfPunts = statisticsService.IsTeam1TotalNumberOfPunts5(statistics);
            Assert.AreNotEqual(9, Team1TotalNumberOfPunts);
        }

        [TestMethod]
        public void Team1TotalPassesAttempted_IsTeam1TotalPassesAttempted35_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassesAttempted = statisticsService.IsTeam1TotalPassesAttempted35(statistics);
            Assert.AreEqual(35, Team1TotalPassesAttempted);
        }

        [TestMethod]
        public void Team1TotalPassesAttempted_IsNotTeam1TotalPassesAttempted35_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassesAttempted = statisticsService.IsTeam1TotalPassesAttempted35(statistics);
            Assert.AreNotEqual(36, Team1TotalPassesAttempted);
        }

        [TestMethod]
        public void Team1TotalPassesCompleted_IsTeam1TotalPassesCompleted25_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassesCompleted = statisticsService.IsTeam1TotalPassesCompleted25(statistics);
            Assert.AreEqual(25, Team1TotalPassesCompleted);
        }

        [TestMethod]
        public void Team1TotalPassesCompleted_IsNotTeam1TotalPassesCompleted25_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassesCompleted = statisticsService.IsTeam1TotalPassesCompleted25(statistics);
            Assert.AreNotEqual(27, Team1TotalPassesCompleted);
        }

        [TestMethod]
        public void Team1TotalPassesIntercepted_IsTeam1TotalPassesIntercepted1_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassesIntercepted = statisticsService.IsTeam1TotalPassesIntercepted1(statistics);
            Assert.AreEqual(1, Team1TotalPassesIntercepted);
        }

        [TestMethod]
        public void Team1TotalPassesIntercepted_IsNotTeam1TotalPassesIntercepted1_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassesIntercepted = statisticsService.IsTeam1TotalPassesIntercepted1(statistics);
            Assert.AreNotEqual(2, Team1TotalPassesIntercepted);
        }

        [TestMethod]
        public void Team1TotalPassingYards_IsTeam1TotalPassingYards300_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassingYards = statisticsService.IsTeam1TotalPassingYards300(statistics);
            Assert.AreEqual(300, Team1TotalPassingYards);
        }

        [TestMethod]
        public void Team1TotalPassingYards_IsNotTeam1TotalPassingYards300_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPassingYards = statisticsService.IsTeam1TotalPassingYards300(statistics);
            Assert.AreNotEqual(290, Team1TotalPassingYards);
        }

        [TestMethod]
        public void Team1TotalRushes_IsTeam1TotalRushes25_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalRushes = statisticsService.IsTeam1TotalRushes25(statistics);
            Assert.AreEqual(25, Team1TotalRushes);
        }

        [TestMethod]
        public void Team1TotalRushes_IsNotTeam1TotalRushes25_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalRushes = statisticsService.IsTeam1TotalRushes25(statistics);
            Assert.AreNotEqual(27, Team1TotalRushes);
        }

        [TestMethod]
        public void Team1TotalRushingYards_IsTeam1TotalRushingYards150_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalRushingYards = statisticsService.IsTeam1TotalRushingYards150(statistics);
            Assert.AreEqual(150, Team1TotalRushingYards);
        }

        [TestMethod]
        public void Team1TotalRushingYards_IsNotTeam1TotalRushingYards150_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalRushingYards = statisticsService.IsTeam1TotalRushingYards150(statistics);
            Assert.AreNotEqual(144, Team1TotalRushingYards);
        }

        [TestMethod]
        public void Team1TotalSackYardsLost_IsTeam1TotalSackYardsLost50_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalSackYardsLost = statisticsService.IsTeam1TotalSackYardsLost50(statistics);
            Assert.AreEqual(50, Team1TotalSackYardsLost);
        }

        [TestMethod]
        public void Team1TotalSackYardsLost_IsNotTeam1TotalSackYardsLost50_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalSackYardsLost = statisticsService.IsTeam1TotalSackYardsLost50(statistics);
            Assert.AreNotEqual(49, Team1TotalSackYardsLost);
        }

        [TestMethod]
        public void Team1TotalScore_IsTeam1TotalScore28_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalScore = statisticsService.IsTeam1TotalScore28(statistics);
            Assert.AreEqual(28, Team1TotalScore);
        }

        [TestMethod]
        public void Team1TotalScore_IsNotTeam1TotalScore28_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalScore = statisticsService.IsTeam1TotalScore28(statistics);
            Assert.AreNotEqual(27, Team1TotalScore);
        }

        [TestMethod]
        public void Team1TotalFumblesLost_IsTeam1TotalFumblesLost1_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalFumblesLost = statisticsService.IsTeam1TotalFumblesLost1(statistics);
            Assert.AreEqual(1, Team1TotalFumblesLost);
        }

        [TestMethod]
        public void Team1TotalFumblesLost_IsNotTeam1TotalFumblesLost1_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalFumblesLost = statisticsService.IsTeam1TotalFumblesLost1(statistics);
            Assert.AreNotEqual(2, Team1TotalFumblesLost);
        }

        [TestMethod]
        public void Team1TotalPenaltyYards_IsTeam1TotalPenaltyYards75_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPenaltyYards = statisticsService.IsTeam1TotalPenaltyYards75(statistics);
            Assert.AreEqual(75, Team1TotalPenaltyYards);
        }

        [TestMethod]
        public void Team1TotalPenaltyYards_IsNotTeam1TotalPenaltyYards75_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalPenaltyYards = statisticsService.IsTeam1TotalPenaltyYards75(statistics);
            Assert.AreNotEqual(72, Team1TotalPenaltyYards);
        }

        [TestMethod]
        public void Team1TotalSacks_IsTeam1TotalSacks3_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalSacks = statisticsService.IsTeam1TotalSacks3(statistics);
            Assert.AreEqual(3, Team1TotalSacks);
        }
        
        [TestMethod]
        public void Team1TotalSacks_IsNotTeam1TotalSacks3_ReturnsTrue()
        {
            var statistics = CreateStatistics(9, 450, 45, 20, 3, 9, 5, 35, 25, 1, 300, 25, 150, 50, 28, 1, 75, 3);
            var statisticsService = _mocker1.Create<StatisticsService>();
            var Team1TotalSacks = statisticsService.IsTeam1TotalSacks3(statistics);
            Assert.AreNotEqual(2, Team1TotalSacks);
        }

        private StatisticsViewModel CreateStatistics(int Team1Id, int Team1TotalYards, int Team1AverageYardsPerPunt, int Team1TotalFirstDowns,
            int Team1TotalFumbles, int Team1TotalNumberOfPenalties, int Team1TotalNumberOfPunts, int Team1TotalPassesAttempted, int Team1TotalPassesCompleted,
            int Team1TotalPassesIntercepted, int Team1TotalPassingYards, int Team1TotalRushes, int Team1TotalRushingYards, int Team1TotalSackYardsLost,
            int Team1TotalTeamScore, int Team1TotalFumblesLost, int Team1TotalPenaltyYards, int Team1TotalSacks)
        {
            return new StatisticsViewModel
            {
                Team1Id = 9,
                Team1TotalYards = 450,
                Team1AverageYardsPerPunt = 45,
                Team1TotalFirstDowns = 20,
                Team1TotalFumbles = 3,
                Team1TotalNumberOfPenalties = 9,
                Team1TotalNumberOfPunts = 5,
                Team1TotalPassesAttempted = 35,
                Team1TotalPassesCompleted = 25,
                Team1TotalPassesIntercepted = 1,
                Team1TotalPassingYards = 300,
                Team1TotalRushes = 25,
                Team1TotalRushingYards = 150,
                Team1TotalSackYardsLost = 50,
                Team1TotalScore = 28,
                Team1TotalFumblesLost = 1,
                Team1TotalPenaltyYards = 75,
                Team1TotalSacks = 3
            };
        }

    }
}
