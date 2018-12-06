using RealTimeSportsStatistics.Shared.Orchestrators;
using RealTimeSportsStatistics.Web.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RealTimeSportsStatistics.Web.Controllers
{
    public class TeamController : Controller
    {
        private TeamOrchestrator _teamOrchestator = new TeamOrchestrator();
        // GET: Team
        [HandleError]
        public async Task<ActionResult> Statistics()
        {
            var teamDisplayModel = new TeamDisplayModel
            {
               Teams = await _teamOrchestator.GetAllTeams()
            };

            return View(teamDisplayModel);
        }
    }
}