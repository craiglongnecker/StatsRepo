using RealTimeSportsStatistics.Shared.Orchestrators;
using RealTimeSportsStatistics.Shared.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RealTimeSportsStatistics.Web.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        [HandleError]
        public ActionResult Game()
        {
            return View();
        }

        private StatisticsOrchestrator _statisticsOrchestrator = new StatisticsOrchestrator();

        public async Task<JsonResult> CreateModel(StatisticsViewModel stats)
        {
            if (stats == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            var result = await _statisticsOrchestrator.SaveStatistics(new StatisticsViewModel
            {
                Team1Id = stats.Team1Id,
                Team1TotalScore = stats.Team1TotalScore,
                Team1TotalYards = stats.Team1TotalYards,
                Team1TotalRushingYards = stats.Team1TotalRushingYards,
                Team1TotalPassingYards = stats.Team1TotalPassingYards,
                Team1TotalSackYardsLost = stats.Team1TotalSackYardsLost,
                Team1TotalPenaltyYards = stats.Team1TotalPenaltyYards,
                Team1AverageYardsPerPunt = stats.Team1AverageYardsPerPunt,
                Team1TotalFirstDowns = stats.Team1TotalFirstDowns,
                Team1TotalRushes = stats.Team1TotalRushes,
                Team1TotalPassesAttempted = stats.Team1TotalPassesAttempted,
                Team1TotalPassesCompleted = stats.Team1TotalPassesCompleted,
                Team1TotalPassesIntercepted = stats.Team1TotalPassesIntercepted,
                Team1TotalSacks = stats.Team1TotalSacks,
                Team1TotalFumbles = stats.Team1TotalFumbles,
                Team1TotalFumblesLost = stats.Team1TotalFumblesLost,
                Team1TotalNumberOfPunts = stats.Team1TotalNumberOfPunts,
                Team1TotalNumberOfPenalties = stats.Team1TotalNumberOfPenalties
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private Statistics1Orchestrator _statistics1Orchestrator = new Statistics1Orchestrator();

        public async Task<JsonResult> CreateModel1(Statistics1ViewModel stats)
        {
            if (stats == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            var result = await _statistics1Orchestrator.SaveStatistics1(new Statistics1ViewModel
            {
                Team2Id = stats.Team2Id,
                Team2TotalScore = stats.Team2TotalScore,
                Team2TotalYards = stats.Team2TotalYards,
                Team2TotalRushingYards = stats.Team2TotalRushingYards,
                Team2TotalPassingYards = stats.Team2TotalPassingYards,
                Team2TotalSackYardsLost = stats.Team2TotalSackYardsLost,
                Team2TotalPenaltyYards = stats.Team2TotalPenaltyYards,
                Team2AverageYardsPerPunt = stats.Team2AverageYardsPerPunt,
                Team2TotalFirstDowns = stats.Team2TotalFirstDowns,
                Team2TotalRushes = stats.Team2TotalRushes,
                Team2TotalPassesAttempted = stats.Team2TotalPassesAttempted,
                Team2TotalPassesCompleted = stats.Team2TotalPassesCompleted,
                Team2TotalPassesIntercepted = stats.Team2TotalPassesIntercepted,
                Team2TotalSacks = stats.Team2TotalSacks,
                Team2TotalFumbles = stats.Team2TotalFumbles,
                Team2TotalFumblesLost = stats.Team2TotalFumblesLost,
                Team2TotalNumberOfPunts = stats.Team2TotalNumberOfPunts,
                Team2TotalNumberOfPenalties = stats.Team2TotalNumberOfPenalties
            });

            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
