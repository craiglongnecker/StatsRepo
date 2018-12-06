using RealTimeSportsStatistics.Shared.Orchestrators;
using System.Dynamic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RealTimeSportsStatistics.Web.Controllers
{
    public class StatisticsController : Controller
    {
        private StatisticsOrchestrator _statisticsOrchestator = new StatisticsOrchestrator();
        private Statistics1Orchestrator _statistics1Orchestator = new Statistics1Orchestrator();

        // GET: Statistics
        [HandleError]
        public async Task<ActionResult> Statistics()
        {
            dynamic statisticsModel = new ExpandoObject();
            statisticsModel.Statistics = await _statisticsOrchestator.GetAllStatistics();
            statisticsModel.Statistics1s = await _statistics1Orchestator.GetAllStatistics1s();
            return View(statisticsModel);
        }
     }
}