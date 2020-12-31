namespace MIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BorcluMusteris",
                c => new
                    {
                        musteriID = c.Int(nullable: false, identity: true),
                        fisNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.musteriID);
            
            CreateTable(
                "dbo.Calisans",
                c => new
                    {
                        calisanID = c.Int(nullable: false, identity: true),
                        calisanSifre = c.Int(nullable: false),
                        calisanAd = c.String(),
                        calisanSoyad = c.String(),
                        calisanGorev = c.String(),
                    })
                .PrimaryKey(t => t.calisanID);
            
            CreateTable(
                "dbo.Depoes",
                c => new
                    {
                        urunID = c.Int(nullable: false, identity: true),
                        urunAdet = c.Int(nullable: false),
                        tedarikciID = c.Int(nullable: false),
                        calisanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.urunID);
            
            CreateTable(
                "dbo.Fis",
                c => new
                    {
                        fisNo = c.Int(nullable: false, identity: true),
                        musteriID = c.Int(nullable: false),
                        islemTarihi = c.String(),
                        odemeTipi = c.Int(nullable: false),
                        islemTutar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.fisNo);
            
            CreateTable(
                "dbo.Irsaliyes",
                c => new
                    {
                        irsaliyeNo = c.Int(nullable: false, identity: true),
                        tedarikciID = c.Int(nullable: false),
                        urunID = c.Int(nullable: false),
                        birimFiyat = c.Int(nullable: false),
                        miktar = c.Int(nullable: false),
                        toplamTutar = c.Int(nullable: false),
                        tarih = c.String(),
                    })
                .PrimaryKey(t => t.irsaliyeNo);
            
            CreateTable(
                "dbo.Islems",
                c => new
                    {
                        fisNo = c.Int(nullable: false, identity: true),
                        urunID = c.Int(nullable: false),
                        islemTarihi = c.String(),
                    })
                .PrimaryKey(t => t.fisNo);
            
            CreateTable(
                "dbo.MusteriBorcs",
                c => new
                    {
                        musteriID = c.Int(nullable: false, identity: true),
                        fisNo = c.Int(nullable: false),
                        calisanID = c.Int(nullable: false),
                        durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.musteriID);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        musteriID = c.Int(nullable: false, identity: true),
                        musteriAlisverisTarihi = c.String(),
                        fisNo = c.Int(nullable: false),
                        musteriAd = c.String(),
                        musteriSoyad = c.String(),
                        musteriTel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.musteriID);
            
            CreateTable(
                "dbo.TedarikciBorcs",
                c => new
                    {
                        tedarikciID = c.Int(nullable: false, identity: true),
                        irsaliyeNo = c.Int(nullable: false),
                        durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.tedarikciID);
            
            CreateTable(
                "dbo.Tedarikcis",
                c => new
                    {
                        tedarikciID = c.Int(nullable: false, identity: true),
                        tedarikciIsim = c.String(),
                    })
                .PrimaryKey(t => t.tedarikciID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tedarikcis");
            DropTable("dbo.TedarikciBorcs");
            DropTable("dbo.Musteris");
            DropTable("dbo.MusteriBorcs");
            DropTable("dbo.Islems");
            DropTable("dbo.Irsaliyes");
            DropTable("dbo.Fis");
            DropTable("dbo.Depoes");
            DropTable("dbo.Calisans");
            DropTable("dbo.BorcluMusteris");
        }
    }
}
