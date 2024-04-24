namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_CongTy", "PhongBanId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_CongTy", "PhongBanId", c => c.Int(nullable: false));
        }
    }
}
