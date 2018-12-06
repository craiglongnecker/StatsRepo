using RealTimeSportsStatistics.Shared.Services.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;

namespace RealTimeSportsStatistics.Shared.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IExistingStatisticsService _existingStatisticsService;

        public StatisticsService(IExistingStatisticsService existingStatisticsService)
        {
            _existingStatisticsService = existingStatisticsService;
        }

        public int IsTeam1Id9(StatisticsViewModel statistics)
        {
            return statistics.Team1Id = _existingStatisticsService.ExistingTeam1Id();
        }
        public int IsTeam1TotalYards450(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalYards = _existingStatisticsService.ExistingTeam1TotalYards();
        }

        public int IsTeam1AverageYardsPerPunt45(StatisticsViewModel statistics)
        {
            return statistics.Team1AverageYardsPerPunt = _existingStatisticsService.ExistingTeam1AverageYardsPerPunt();
        }

        public int IsTeam1TotalFirstDowns20(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalFirstDowns = _existingStatisticsService.ExistingTeam1TotalFirstDowns();
        }

        public int IsTeam1TotalFumbles3(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalFumbles = _existingStatisticsService.ExistingTeam1TotalFumbles();
        }

        public int IsTeam1TotalNumberOfPenalties9(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalNumberOfPenalties = _existingStatisticsService.ExistingTeam1TotalNumberOfPenalties();
        }

        public int IsTeam1TotalNumberOfPunts5(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalNumberOfPunts = _existingStatisticsService.ExistingTeam1TotalNumberOfPunts();
        }

        public int IsTeam1TotalPassesAttempted35(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalPassesAttempted = _existingStatisticsService.ExistingTeam1TotalPassesAttempted();
        }

        public int IsTeam1TotalPassesCompleted25(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalPassesCompleted = _existingStatisticsService.ExistingTeam1TotalPassesCompleted();
        }

        public int IsTeam1TotalPassesIntercepted1(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalPassesIntercepted = _existingStatisticsService.ExistingTeam1TotalPassesIntercepted();
        }

        public int IsTeam1TotalPassingYards300(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalPassingYards = _existingStatisticsService.ExistingTeam1TotalPassingYards();
        }

        public int IsTeam1TotalRushes25(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalRushes = _existingStatisticsService.ExistingTeam1TotalRushes();
        }

        public int IsTeam1TotalRushingYards150(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalRushingYards = _existingStatisticsService.ExistingTeam1TotalRushingYards();
        }

        public int IsTeam1TotalSackYardsLost50(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalSackYardsLost = _existingStatisticsService.ExistingTeam1TotalSackYardsLost();
        }

        public int IsTeam1TotalScore28(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalScore = _existingStatisticsService.ExistingTeam1TotalScore();
        }

        public int IsTeam1TotalFumblesLost1(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalFumblesLost = _existingStatisticsService.ExistingTeam1TotalFumblesLost();
        }

        public int IsTeam1TotalPenaltyYards75(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalPenaltyYards = _existingStatisticsService.ExistingTeam1TotalPenaltyYards();
        }

        public int IsTeam1TotalSacks3(StatisticsViewModel statistics)
        {
            return statistics.Team1TotalSacks = _existingStatisticsService.ExistingTeam1TotalSacks();
        }
    }
}
