using RealTimeSportsStatistics.Domain;
using RealTimeSportsStatistics.Shared.Orchestrators.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RealTimeSportsStatistics.Shared.Orchestrators

{
public class StatisticsOrchestrator : IStatisticsOrchestrator
{
    private TeamContext _statisticsContext;

    public StatisticsOrchestrator()
    {
        _statisticsContext = new TeamContext();
    }
        public async Task<List<StatisticsViewModel>> GetAllStatistics()
        {
            var statistics = await _statisticsContext.Statistics.Select(x => new StatisticsViewModel
            {
                Team1Id = x.Team1Id,
                Team = x.Team,
                Team1TotalScore = x.Team1TotalScore,
                Team1TotalYards = x.Team1TotalYards,
                Team1TotalRushingYards = x.Team1TotalRushingYards,
                Team1TotalPassingYards = x.Team1TotalPassingYards,
                Team1TotalSackYardsLost = x.Team1TotalSackYardsLost,
                Team1TotalPenaltyYards = x.Team1TotalPenaltyYards,
                Team1AverageYardsPerPunt = x.Team1AverageYardsPerPunt,
                Team1TotalFirstDowns = x.Team1TotalFirstDowns,
                Team1TotalRushes = x.Team1TotalRushes,
                Team1TotalPassesAttempted = x.Team1TotalPassesAttempted,
                Team1TotalPassesCompleted = x.Team1TotalPassesCompleted,
                Team1TotalPassesIntercepted = x.Team1TotalPassesIntercepted,
                Team1TotalSacks = x.Team1TotalSacks,
                Team1TotalFumbles = x.Team1TotalFumbles,
                Team1TotalFumblesLost = x.Team1TotalFumblesLost,
                Team1TotalNumberOfPunts = x.Team1TotalNumberOfPunts,
                Team1TotalNumberOfPenalties = x.Team1TotalNumberOfPenalties
            }).ToListAsync();
            return statistics;
        }
    }
}