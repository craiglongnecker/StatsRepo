using RealTimeSportsStatistics.Domain;
using RealTimeSportsStatistics.Shared.Orchestrators.Interfaces;
using RealTimeSportsStatistics.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System;
using System.IO;

namespace RealTimeSportsStatistics.Shared.Orchestrators
{
    public class Statistics1Orchestrator : IStatistics1Orchestrator
    {
        private TeamContext _statistics1Context;
        public Statistics1Orchestrator()
        {
            _statistics1Context = new TeamContext();
        }
        public async Task<List<Statistics1ViewModel>> GetAllStatistics1s()
        {
            var statistics1 = await _statistics1Context.Statistics1s.Select(x => new Statistics1ViewModel
            {
                Team2Id = x.Team2Id,
                Team = x.Team,
                Team2TotalScore = x.Team2TotalScore,
                Team2TotalYards = x.Team2TotalYards,
                Team2TotalRushingYards = x.Team2TotalRushingYards,
                Team2TotalPassingYards = x.Team2TotalPassingYards,
                Team2TotalSackYardsLost = x.Team2TotalSackYardsLost,
                Team2TotalPenaltyYards = x.Team2TotalPenaltyYards,
                Team2AverageYardsPerPunt = x.Team2AverageYardsPerPunt,
                Team2TotalFirstDowns = x.Team2TotalFirstDowns,
                Team2TotalRushes = x.Team2TotalRushes,
                Team2TotalPassesAttempted = x.Team2TotalPassesAttempted,
                Team2TotalPassesCompleted = x.Team2TotalPassesCompleted,
                Team2TotalPassesIntercepted = x.Team2TotalPassesIntercepted,
                Team2TotalSacks = x.Team2TotalSacks,
                Team2TotalFumbles = x.Team2TotalFumbles,
                Team2TotalFumblesLost = x.Team2TotalFumblesLost,
                Team2TotalNumberOfPunts = x.Team2TotalNumberOfPunts,
                Team2TotalNumberOfPenalties = x.Team2TotalNumberOfPenalties
            }).ToListAsync();
            return statistics1;
        }

        public async Task<bool> SaveStatistics1(Statistics1ViewModel stats)
        {
            try
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                  new SqlConnection("Server=localhost\\SQLEXPRESS;Trusted_Connection=True;Initial Catalog=RealTimeSportsStatistics;Integrated Security = SSPI");
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = @"
                Insert into [Statistics1](Team2Id, Team2TotalScore, Team2TotalYards, Team2TotalRushingYards, Team2TotalPassingYards, Team2TotalSackYardsLost, Team2TotalPenaltyYards, Team2AverageYardsPerPunt, Team2TotalFirstDowns, Team2TotalRushes, Team2TotalPassesAttempted, Team2TotalPassesCompleted, Team2TotalPassesIntercepted, Team2TotalSacks, Team2TotalFumbles, Team2TotalFumblesLost, Team2TotalNumberOfPunts, Team2TotalNumberOfPenalties) " +
                    "Values('" + stats.Team2Id + "', '" + stats.Team2TotalScore + "', '" + stats.Team2TotalYards + "', '" + stats.Team2TotalRushingYards + "', '" + stats.Team2TotalPassingYards + "', '" + stats.Team2TotalSackYardsLost + "', '" + stats.Team2TotalPenaltyYards + "', '" + stats.Team2AverageYardsPerPunt + "', '" + stats.Team2TotalFirstDowns + "', '" + stats.Team2TotalRushes + "', '" + stats.Team2TotalPassesAttempted + "', '" + stats.Team2TotalPassesCompleted + "', '" + stats.Team2TotalPassesIntercepted + "', '" + stats.Team2TotalSacks + "', '" + stats.Team2TotalFumbles + "', '" + stats.Team2TotalFumblesLost + "', '" + stats.Team2TotalNumberOfPunts + "', '" + stats.Team2TotalNumberOfPenalties + "')",
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
