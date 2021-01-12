namespace Control_cash.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.debitoes", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.debitoes", "Data", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.debitoes", "Data", c => c.String());
            AlterColumn("dbo.debitoes", "Valor", c => c.Single(nullable: false));
        }
    }
}
