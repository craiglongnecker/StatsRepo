using System.ComponentModel.DataAnnotations;

namespace RealTimeSportsStatistics.Domain.Entities
{
    public class Statistics1
    {
        [Key]
        public int Team2Id { get; set; }
        public Team Team { get; set; }
        public int Team2TotalScore { get; set; }
        public int Team2TotalYards { get; set; }
        public int Team2TotalRushingYards { get; set; }
        public int Team2TotalPassingYards { get; set; }
        public int Team2TotalSackYardsLost { get; set; }
        public int Team2TotalPenaltyYards { get; set; }
        public int Team2AverageYardsPerPunt { get; set; }
        public int Team2TotalFirstDowns { get; set; }
        public int Team2TotalRushes { get; set; }
        public int Team2TotalPassesAttempted { get; set; }
        public int Team2TotalPassesCompleted { get; set; }
        public int Team2TotalPassesIntercepted { get; set; }
        public int Team2TotalSacks { get; set; }
        public int Team2TotalFumbles { get; set; }
        public int Team2TotalFumblesLost { get; set; }
        public int Team2TotalNumberOfPunts { get; set; }
        public int Team2TotalNumberOfPenalties { get; set; }
    }
}
