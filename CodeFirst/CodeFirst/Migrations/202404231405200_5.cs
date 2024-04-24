namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_PhongBan", "NhanVienId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_PhongBan", "NhanVienId", c => c.Int(nullable: false));
        }
    }
}
