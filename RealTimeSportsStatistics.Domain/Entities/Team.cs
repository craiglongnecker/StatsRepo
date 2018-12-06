using System.ComponentModel.DataAnnotations;

namespace RealTimeSportsStatistics.Domain.Entities
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamCity { get; set; }
        public string TeamName { get; set; }
        public string ColorOne { get; set; }
        public string ColorTwo { get; set; }
    }
}
