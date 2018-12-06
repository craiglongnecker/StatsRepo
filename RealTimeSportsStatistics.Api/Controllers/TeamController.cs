using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace RealTimeSportsStatistics.Api.Controllers
{
    [Route("api/v1/teams")]
    public class TeamController : ApiController
    {
        private Shared.Orchestrators.TeamOrchestrator _teamOrchestrator;

        public TeamController()
        {
            _teamOrchestrator = new Shared.Orchestrators.TeamOrchestrator();
        }

        public async Task<List<TeamViewModel>> GetAllTeams()
        {

            var teams = await _teamOrchestrator.GetAllTeams();

            return teams;
        }
    }
}

