using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RealTimeSportsStatistics.Shared.Orchestrators.Interfaces
{
    public interface ITeamOrchestrator
    {
        Task<List<TeamViewModel>> GetAllTeams();
    }
}
