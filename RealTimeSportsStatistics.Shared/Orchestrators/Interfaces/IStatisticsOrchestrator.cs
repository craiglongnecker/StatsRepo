using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeSportsStatistics.Shared.Orchestrators.Interfaces
{
    public interface IStatisticsOrchestrator
    {
        Task<List<StatisticsViewModel>> GetAllStatistics();
    }
}
