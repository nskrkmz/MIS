namespace MIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        urunID = c.Int(nullable: false, identity: true),
                        depoTarih = c.String(),
                        urunAlisFiyat = c.Int(nullable: false),
                        urunGr = c.Int(nullable: false),
                        urunSTT = c.String(),
                        irsaliyeNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.urunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
        }
    }
}
