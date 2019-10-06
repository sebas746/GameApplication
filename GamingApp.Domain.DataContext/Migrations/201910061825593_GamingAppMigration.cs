namespace GamingApp.Domain.DataContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamingAppMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameStatistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Player1Name = c.String(maxLength: 50),
                        Player2Name = c.String(maxLength: 50),
                        PlayerWinner = c.String(maxLength: 50),
                        TimeStamp = c.DateTime(),
                        FinalScore = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GameStatistics");
        }
    }
}
