using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace RealTimeSportsStatistics.Api.Controllers
{
    [Route("api/v1/statistics")]
    public class StatisticsController : ApiController
    {
        private Shared.Orchestrators.StatisticsOrchestrator _statisticsOrchestrator;

        public StatisticsController()
        {
            _statisticsOrchestrator = new Shared.Orchestrators.StatisticsOrchestrator();
        }

        public async Task<List<StatisticsViewModel>> GetAllStatistics()
        {

            var statistics = await _statisticsOrchestrator.GetAllStatistics();

            return statistics;
        }
    }
}
