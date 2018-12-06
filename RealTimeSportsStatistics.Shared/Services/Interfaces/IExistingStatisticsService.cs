namespace RealTimeSportsStatistics.Shared.Services.Interfaces
{
    public interface IExistingStatisticsService
    {
        int ExistingTeam1Id();
        int ExistingTeam1TotalScore();
        int ExistingTeam1TotalYards();
        int ExistingTeam1TotalRushingYards();
        int ExistingTeam1TotalPassingYards();
        int ExistingTeam1TotalSackYardsLost();
        int ExistingTeam1TotalPenaltyYards();
        int ExistingTeam1AverageYardsPerPunt();
        int ExistingTeam1TotalFirstDowns();
        int ExistingTeam1TotalRushes();
        int ExistingTeam1TotalPassesAttempted();
        int ExistingTeam1TotalPassesCompleted();
        int ExistingTeam1TotalPassesIntercepted();
        int ExistingTeam1TotalSacks();
        int ExistingTeam1TotalFumbles();
        int ExistingTeam1TotalFumblesLost();
        int ExistingTeam1TotalNumberOfPunts();
        int ExistingTeam1TotalNumberOfPenalties();
    }
}
