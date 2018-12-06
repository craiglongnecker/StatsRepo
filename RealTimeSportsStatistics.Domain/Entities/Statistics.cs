using System.ComponentModel.DataAnnotations;

namespace RealTimeSportsStatistics.Domain.Entities
{
    public class Statistics
    {
        [Key]
        public int Team1Id { get; set; }
        public Team Team { get; set; }
        public int Team1TotalScore { get; set; }
        public int Team1TotalYards { get; set; }
        public int Team1TotalRushingYards { get; set; }
        public int Team1TotalPassingYards { get; set; }
        public int Team1TotalSackYardsLost { get; set; }
        public int Team1TotalPenaltyYards { get; set; }
        public int Team1AverageYardsPerPunt { get; set; }
        public int Team1TotalFirstDowns { get; set; }
        public int Team1TotalRushes { get; set; }
        public int Team1TotalPassesAttempted { get; set; }
        public int Team1TotalPassesCompleted { get; set; }
        public int Team1TotalPassesIntercepted { get; set; }
        public int Team1TotalSacks { get; set; }
        public int Team1TotalFumbles { get; set; }
        public int Team1TotalFumblesLost { get; set; }
        public int Team1TotalNumberOfPunts { get; set; }
        public int Team1TotalNumberOfPenalties { get; set; }
    }
}
