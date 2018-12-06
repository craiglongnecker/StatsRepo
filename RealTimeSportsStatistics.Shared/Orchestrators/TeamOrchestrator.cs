using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using RealTimeSportsStatistics.Domain;
using RealTimeSportsStatistics.Shared.Orchestrators.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;

namespace RealTimeSportsStatistics.Shared.Orchestrators
{

    public class TeamOrchestrator : ITeamOrchestrator
    {
        private TeamContext _teamContext;

        public TeamOrchestrator()
        {
            _teamContext = new TeamContext();
        }
        public async Task<List<TeamViewModel>> GetAllTeams()
        {
            var teams = await _teamContext.Teams.Select(x => new TeamViewModel
            {
                TeamID = x.TeamId,
                TeamCity = x.TeamCity,
                TeamName = x.TeamName,
                ColorOne = x.ColorOne,
                ColorTwo = x.ColorTwo
            }).ToListAsync();

            return teams;
        }
    }
}
