namespace RealTimeSportsStatistics.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseWithTeamsAndStatisticsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        Team1Id = c.Int(nullable: false, identity: true),
                        Team1TotalScore = c.Int(nullable: false),
                        Team1TotalYards = c.Int(nullable: false),
                        Team1TotalRushingYards = c.Int(nullable: false),
                        Team1TotalPassingYards = c.Int(nullable: false),
                        Team1TotalSackYardsLost = c.Int(nullable: false),
                        Team1TotalPenaltyYards = c.Int(nullable: false),
                        Team1AverageYardsPerPunt = c.Int(nullable: false),
                        Team1TotalFirstDowns = c.Int(nullable: false),
                        Team1TotalRushes = c.Int(nullable: false),
                        Team1TotalPassesAttempted = c.Int(nullable: false),
                        Team1TotalPassesCompleted = c.Int(nullable: false),
                        Team1TotalPassesIntercepted = c.Int(nullable: false),
                        Team1TotalSacks = c.Int(nullable: false),
                        Team1TotalFumbles = c.Int(nullable: false),
                        Team1TotalFumblesLost = c.Int(nullable: false),
                        Team1TotalNumberOfPunts = c.Int(nullable: false),
                        Team1TotalNumberOfPenalties = c.Int(nullable: false),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Team1Id)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamCity = c.String(),
                        TeamName = c.String(),
                        ColorOne = c.String(),
                        ColorTwo = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.Statistics1",
                c => new
                    {
                        Team2Id = c.Int(nullable: false, identity: true),
                        Team2TotalScore = c.Int(nullable: false),
                        Team2TotalYards = c.Int(nullable: false),
                        Team2TotalRushingYards = c.Int(nullable: false),
                        Team2TotalPassingYards = c.Int(nullable: false),
                        Team2TotalSackYardsLost = c.Int(nullable: false),
                        Team2TotalPenaltyYards = c.Int(nullable: false),
                        Team2AverageYardsPerPunt = c.Int(nullable: false),
                        Team2TotalFirstDowns = c.Int(nullable: false),
                        Team2TotalRushes = c.Int(nullable: false),
                        Team2TotalPassesAttempted = c.Int(nullable: false),
                        Team2TotalPassesCompleted = c.Int(nullable: false),
                        Team2TotalPassesIntercepted = c.Int(nullable: false),
                        Team2TotalSacks = c.Int(nullable: false),
                        Team2TotalFumbles = c.Int(nullable: false),
                        Team2TotalFumblesLost = c.Int(nullable: false),
                        Team2TotalNumberOfPunts = c.Int(nullable: false),
                        Team2TotalNumberOfPenalties = c.Int(nullable: false),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Team2Id)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Team_TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Statistics1", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Statistics", "Team_TeamId", "dbo.Teams");
            DropIndex("dbo.Statistics1", new[] { "Team_TeamId" });
            DropIndex("dbo.Statistics", new[] { "Team_TeamId" });
            DropTable("dbo.Statistics1");
            DropTable("dbo.Teams");
            DropTable("dbo.Statistics");
        }
    }
}
