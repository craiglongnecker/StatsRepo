using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeSportsStatistics.Shared.Orchestrators.Interfaces
{
    public interface IStatistics1Orchestrator
    {
        Task<List<Statistics1ViewModel>> GetAllStatistics1s();
    }
}
