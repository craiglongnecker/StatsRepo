using RealTimeSportsStatistics.Shared.Services.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;

namespace RealTimeSportsStatistics.Shared.Services
{
    public class TeamService : ITeamService
    {
        private readonly IExistingTeamService _existingTeamService;

        public TeamService(IExistingTeamService existingTeamService)
        {
            _existingTeamService = existingTeamService;
        }

        public string IsTeamCityDenver(TeamViewModel team)
        {
            return team.TeamCity = _existingTeamService.ExistingTeamCity();
        }

        public string IsTeamNameBroncos(TeamViewModel team)
        {
            return team.TeamName = _existingTeamService.ExistingTeamName();
        }

        public string IsBroncosPrimaryColorBlue(TeamViewModel team)
        {
            return team.TeamName = _existingTeamService.ExistingColorOne();
        }

        public string IsBroncosSecondaryColorOrange(TeamViewModel team)
        {
            return team.TeamName = _existingTeamService.ExistingColorTwo();
        }
    }
}
