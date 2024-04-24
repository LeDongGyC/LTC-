namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_CongTy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        PhongBanId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_PhongBan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NhanVienId = c.Int(nullable: false),
                        CongTy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_CongTy", t => t.CongTy_Id)
                .Index(t => t.CongTy_Id);
            
            AddColumn("dbo.tb_NhanVien", "PhongBan_Id", c => c.Int());
            CreateIndex("dbo.tb_NhanVien", "PhongBan_Id");
            AddForeignKey("dbo.tb_NhanVien", "PhongBan_Id", "dbo.tb_PhongBan", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_NhanVien", "PhongBan_Id", "dbo.tb_PhongBan");
            DropForeignKey("dbo.tb_PhongBan", "CongTy_Id", "dbo.tb_CongTy");
            DropIndex("dbo.tb_NhanVien", new[] { "PhongBan_Id" });
            DropIndex("dbo.tb_PhongBan", new[] { "CongTy_Id" });
            DropColumn("dbo.tb_NhanVien", "PhongBan_Id");
            DropTable("dbo.tb_PhongBan");
            DropTable("dbo.tb_CongTy");
        }
    }
}
