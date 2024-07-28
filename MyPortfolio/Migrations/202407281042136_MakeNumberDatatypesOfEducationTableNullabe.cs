namespace MyPortfolio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeNumberDatatypesOfEducationTableNullabe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Education", "PercentageOrCGPA", c => c.Double());
            AlterColumn("dbo.Education", "PassingYear", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Education", "PassingYear", c => c.Int(nullable: false));
            AlterColumn("dbo.Education", "PercentageOrCGPA", c => c.Double(nullable: false));
        }
    }
}
