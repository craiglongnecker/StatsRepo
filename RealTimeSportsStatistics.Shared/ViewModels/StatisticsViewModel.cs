using RealTimeSportsStatistics.Domain.Entities;

namespace RealTimeSportsStatistics.Shared.ViewModels
{
    public class StatisticsViewModel
    {
        public int Team1Id { get; set; }
        public Team Team { get; set; }
        public string Team1IdString => Team1Id.ToString();
        public int Team1TotalScore { get; set; }
        public string Team1TotalScoreString => Team1TotalScore.ToString();
        public int Team1TotalYards { get; set; }
        public string Team1TotalYardsString => Team1TotalYards.ToString();
        public int Team1TotalRushingYards { get; set; }
        public string Team1RushingYardsString => Team1TotalRushingYards.ToString();
        public int Team1TotalPassingYards { get; set; }
        public string Team1TotalPassingYardsString => Team1TotalPassingYards.ToString();
        public int Team1TotalSackYardsLost { get; set; }
        public string Team1TotalSackYardsLostString => Team1TotalSackYardsLost.ToString();
        public int Team1TotalPenaltyYards { get; set; }
        public string Team1TotalPenaltyYardsString => Team1TotalPenaltyYards.ToString();
        public int Team1AverageYardsPerPunt { get; set; }
        public string Team1AverageYardsPerPuntString => Team1AverageYardsPerPunt.ToString();
        public int Team1TotalFirstDowns { get; set; }
        public string Team1TotalFirstDownsString => Team1TotalFirstDowns.ToString();
        public int Team1TotalRushes { get; set; }
        public string Team1TotalRushesString => Team1TotalRushes.ToString();
        public int Team1TotalPassesAttempted { get; set; }
        public string Team1TotalPassesAttemptedString => Team1TotalPassesAttempted.ToString();
        public int Team1TotalPassesCompleted { get; set; }
        public string Team1TotalPassesCompletedString => Team1TotalPassesCompleted.ToString();
        public int Team1TotalPassesIntercepted { get; set; }
        public string Team1TotalPassessInterceptedString => Team1TotalPassesIntercepted.ToString();
        public int Team1TotalSacks { get; set; }
        public string Team1TotalSacksString => Team1TotalSacks.ToString();
        public int Team1TotalFumbles { get; set; }
        public string Team1TotalFumblesString => Team1TotalFumbles.ToString();
        public int Team1TotalFumblesLost { get; set; }
        public string Team1TotalFumblesLostString => Team1TotalFumblesLost.ToString();
        public int Team1TotalNumberOfPunts { get; set; }
        public string Team1TotalNumberOfPuntsString => Team1TotalNumberOfPunts.ToString();
        public int Team1TotalNumberOfPenalties { get; set; }
        public string Team1TotalNumberOfPenaltiesString => Team1TotalNumberOfPenalties.ToString();
    }
}
