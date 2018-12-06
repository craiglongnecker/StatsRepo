using RealTimeSportsStatistics.Domain;
using RealTimeSportsStatistics.Shared.Orchestrators.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RealTimeSportsStatistics.Shared.Orchestrators
{
    public class Statistics1Orchestrator : IStatistics1Orchestrator
    {
        private TeamContext _statistics1Context;
        public Statistics1Orchestrator()
        {
            _statistics1Context = new TeamContext();
        }
        public async Task<List<Statistics1ViewModel>> GetAllStatistics1s()
        {
            var statistics1 = await _statistics1Context.Statistics1s.Select(x => new Statistics1ViewModel
            {
                Team2Id = x.Team2Id,
                Team = x.Team,
                Team2TotalScore = x.Team2TotalScore,
                Team2TotalYards = x.Team2TotalYards,
                Team2TotalRushingYards = x.Team2TotalRushingYards,
                Team2TotalPassingYards = x.Team2TotalPassingYards,
                Team2TotalSackYardsLost = x.Team2TotalSackYardsLost,
                Team2TotalPenaltyYards = x.Team2TotalPenaltyYards,
                Team2AverageYardsPerPunt = x.Team2AverageYardsPerPunt,
                Team2TotalFirstDowns = x.Team2TotalFirstDowns,
                Team2TotalRushes = x.Team2TotalRushes,
                Team2TotalPassesAttempted = x.Team2TotalPassesAttempted,
                Team2TotalPassesCompleted = x.Team2TotalPassesCompleted,
                Team2TotalPassesIntercepted = x.Team2TotalPassesIntercepted,
                Team2TotalSacks = x.Team2TotalSacks,
                Team2TotalFumbles = x.Team2TotalFumbles,
                Team2TotalFumblesLost = x.Team2TotalFumblesLost,
                Team2TotalNumberOfPunts = x.Team2TotalNumberOfPunts,
                Team2TotalNumberOfPenalties = x.Team2TotalNumberOfPenalties
            }).ToListAsync();
            return statistics1;
        }
    }
}
