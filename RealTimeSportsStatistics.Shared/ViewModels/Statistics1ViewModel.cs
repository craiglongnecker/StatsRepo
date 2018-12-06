
using RealTimeSportsStatistics.Domain.Entities;

namespace RealTimeSportsStatistics.Shared.ViewModels
{
    public class Statistics1ViewModel
    {
        public int Team2Id { get; set; }
        public Team Team { get; set; }
        public string Team2IdString => Team2Id.ToString();
        public int Team2TotalScore { get; set; }
        public string Team2TotalScoreString => Team2TotalScore.ToString();
        public int Team2TotalYards { get; set; }
        public string Team2TotalYardsString => Team2TotalYards.ToString();
        public int Team2TotalRushingYards { get; set; }
        public string Team2RushingYardsString => Team2TotalRushingYards.ToString();
        public int Team2TotalPassingYards { get; set; }
        public string Team2TotalPassingYardsString => Team2TotalPassingYards.ToString();
        public int Team2TotalSackYardsLost { get; set; }
        public string Team2TotalSackYardsLostString => Team2TotalSackYardsLost.ToString();
        public int Team2TotalPenaltyYards { get; set; }
        public string Team2TotalPenaltyYardsString => Team2TotalPenaltyYards.ToString();
        public int Team2AverageYardsPerPunt { get; set; }
        public string Team2AverageYardsPerPuntString => Team2AverageYardsPerPunt.ToString();
        public int Team2TotalFirstDowns { get; set; }
        public string Team2TotalFirstDownsString => Team2TotalFirstDowns.ToString();
        public int Team2TotalRushes { get; set; }
        public string Team2TotalRushesString => Team2TotalRushes.ToString();
        public int Team2TotalPassesAttempted { get; set; }
        public string Team2TotalPassesAttemptedString => Team2TotalPassesAttempted.ToString();
        public int Team2TotalPassesCompleted { get; set; }
        public string Team2TotalPassesCompletedString => Team2TotalPassesCompleted.ToString();
        public int Team2TotalPassesIntercepted { get; set; }
        public string Team2TotalPassessInterceptedString => Team2TotalPassesIntercepted.ToString();
        public int Team2TotalSacks { get; set; }
        public string Team2TotalSacksString => Team2TotalSacks.ToString();
        public int Team2TotalFumbles { get; set; }
        public string Team2TotalFumblesString => Team2TotalFumbles.ToString();
        public int Team2TotalFumblesLost { get; set; }
        public string Team2TotalFumblesLostString => Team2TotalFumblesLost.ToString();
        public int Team2TotalNumberOfPunts { get; set; }
        public string Team2TotalNumberOfPuntsString => Team2TotalNumberOfPunts.ToString();
        public int Team2TotalNumberOfPenalties { get; set; }
        public string Team2TotalNumberOfPenaltiesString => Team2TotalNumberOfPenalties.ToString();
    }
}
