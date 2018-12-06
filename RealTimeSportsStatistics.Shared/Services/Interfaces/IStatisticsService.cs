using RealTimeSportsStatistics.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealTimeSportsStatistics.Shared.Services.Interfaces
{
    public interface IStatisticsService
    {
        int IsTeam1Id9(StatisticsViewModel statistics);
        int IsTeam1TotalScore28(StatisticsViewModel statistics);
        int IsTeam1TotalRushingYards150(StatisticsViewModel statistics);
        int IsTeam1TotalPassingYards300(StatisticsViewModel statistics);
        int IsTeam1TotalSackYardsLost50(StatisticsViewModel statistics);
        int IsTeam1TotalPenaltyYards75(StatisticsViewModel statistics);
        int IsTeam1AverageYardsPerPunt45(StatisticsViewModel statistics);
        int IsTeam1TotalFirstDowns20(StatisticsViewModel statistics);
        int IsTeam1TotalRushes25(StatisticsViewModel statistics);
        int IsTeam1TotalPassesAttempted35(StatisticsViewModel statistics);
        int IsTeam1TotalPassesCompleted25(StatisticsViewModel statistics);
        int IsTeam1TotalPassesIntercepted1(StatisticsViewModel statistics);
        int IsTeam1TotalSacks3(StatisticsViewModel statistics);
        int IsTeam1TotalFumbles3(StatisticsViewModel statistics);
        int IsTeam1TotalFumblesLost1(StatisticsViewModel statistics);
        int IsTeam1TotalNumberOfPunts5(StatisticsViewModel statistics);
        int IsTeam1TotalNumberOfPenalties9(StatisticsViewModel statistics);    }
}
