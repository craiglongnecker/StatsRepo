using AutoMoq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealTimeSportsStatistics.Shared.Services;
using RealTimeSportsStatistics.Shared.Services.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;

namespace RealTimeSportsStatistics.Test
{
    [TestClass]
    public class TeamServiceTests
    {
        private readonly AutoMoqer _mocker2 = new AutoMoqer();

        [TestInitialize]
        public void Initialize()
        {
            _mocker2.GetMock<IExistingTeamService>()
                    .Setup(x => x.ExistingTeamCity())
                    .Returns("Denver");
            _mocker2.GetMock<IExistingTeamService>()
                    .Setup(x => x.ExistingTeamName())
                    .Returns("Broncos");
            _mocker2.GetMock<IExistingTeamService>()
                    .Setup(x => x.ExistingColorTwo())
                    .Returns("Blue");
            _mocker2.GetMock<IExistingTeamService>()
                    .Setup(x => x.ExistingColorTwo())
                    .Returns("Orange");
        }

        [TestMethod]
        public void TeamCity_IfTeamCityIsDenver_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var TeamCity = teamService.IsTeamCityDenver(team);
            Assert.AreEqual("Denver", TeamCity);
        }

        [TestMethod]
        public void TeamCity_IfTeamCityIsNotDenver_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var TeamCity = teamService.IsTeamCityDenver(team);
            Assert.AreNotEqual("Minnesota", TeamCity);
        }

        [TestMethod]
        public void TeamCity_IfTeamNameIsBroncos_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var TeamName = teamService.IsTeamNameBroncos(team);
            Assert.AreEqual("Broncos", TeamName);
        }

        [TestMethod]
        public void TeamCity_IfTeamNameIsNotBroncos_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var TeamName = teamService.IsTeamNameBroncos(team);
            Assert.AreNotEqual("Vikings", TeamName);
        }

        [TestMethod]
        public void TeamColorOne_IsBroncosPrimaryColorBlue_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var ColorOne = teamService.IsBroncosPrimaryColorBlue(team);
            Assert.AreNotEqual("Blue", ColorOne);
        }

        [TestMethod]
        public void TeamColorOne_IsBroncosPrimaryColorNotBlue_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var ColorOne = teamService.IsBroncosPrimaryColorBlue(team);
            Assert.AreNotEqual("Red", ColorOne);
        }

        [TestMethod]
        public void TeamColorTwo_IsBroncosSecondaryColorOrange_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var ColorTwo = teamService.IsBroncosSecondaryColorOrange(team);
            Assert.AreEqual("Orange", ColorTwo);
        }

        [TestMethod]
        public void TeamColorTwo_IsBroncosSecondaryColorNotOrange_ReturnsTrue()
        {
            var team = CreateTeam("Denver", "Broncos", "Blue", "Orange");
            var teamService = _mocker2.Create<TeamService>();
            var ColorTwo = teamService.IsBroncosSecondaryColorOrange(team);
            Assert.AreNotEqual("Yellow", ColorTwo);
        }

        private TeamViewModel CreateTeam(string TeamCity, string TeamName, string ColorOne, string ColorTwo)
        {
            return new TeamViewModel
            {
                TeamID = 11,
                TeamCity = "Denver",
                TeamName = "Broncos",
                ColorOne = "Blue",
                ColorTwo = "Orange"
            };
        }
    }
}

