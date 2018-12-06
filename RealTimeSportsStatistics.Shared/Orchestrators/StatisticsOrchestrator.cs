using RealTimeSportsStatistics.Domain;
using RealTimeSportsStatistics.Shared.Orchestrators.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System;

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

        public async Task<bool> SaveStatistics(StatisticsViewModel stats)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                  new SqlConnection("Server=localhost\\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=RealTimeSportsStatistics;Integrated Security = SSPI");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = @"
                Insert into [Statistics](Team1Id, Team1TotalScore, Team1TotalYards, Team1TotalRushingYards, Team1TotalPassingYards, Team1TotalSackYardsLost, Team1TotalPenaltyYards, Team1AverageYardsPerPunt, Team1TotalFirstDowns, Team1TotalRushes, Team1TotalPassesAttempted, Team1TotalPassesCompleted, Team1TotalPassesIntercepted, Team1TotalSacks, Team1TotalFumbles, Team1TotalFumblesLost, Team1TotalNumberOfPunts, Team1TotalNumberOfPenalties) " +
                    "Values('" + stats.Team1Id + "', '" + stats.Team1TotalScore + "', '" + stats.Team1TotalYards + "', '" + stats.Team1TotalRushingYards + "', '" + stats.Team1TotalPassingYards + "', '" + stats.Team1TotalSackYardsLost + "', '" + stats.Team1TotalPenaltyYards + "', '" + stats.Team1AverageYardsPerPunt + "', '" + stats.Team1TotalFirstDowns + "', '" + stats.Team1TotalRushes + "', '" + stats.Team1TotalPassesAttempted + "', '" + stats.Team1TotalPassesCompleted + "', '" + stats.Team1TotalPassesIntercepted + "', '" + stats.Team1TotalSacks + "', '" + stats.Team1TotalFumbles + "', '" + stats.Team1TotalFumblesLost + "', '" + stats.Team1TotalNumberOfPunts + "', '" + stats.Team1TotalNumberOfPenalties + "')",
                    Connection = sqlConnection1

                };
                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

            }
            catch (Exception e)
            {
                File.WriteAllText(@"c:\Temp\Error.Txt", e.Message);
            }
            return true;
        }
    }
}