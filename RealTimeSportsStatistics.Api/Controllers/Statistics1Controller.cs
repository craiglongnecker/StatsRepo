using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace RealTimeSportsStatistics.Api.Controllers
{
    [Route("api/v1/statistics1")]
    public class Statistics1Controller : ApiController
    {
        private Shared.Orchestrators.Statistics1Orchestrator _statistics1Orchestrator;

        public Statistics1Controller()
        {
            _statistics1Orchestrator = new Shared.Orchestrators.Statistics1Orchestrator();
        }

        public async Task<List<Statistics1ViewModel>> GetAllStatistics1s()
        {

            var statistics = await _statistics1Orchestrator.GetAllStatistics1s();

            return statistics;
        }
    }
}