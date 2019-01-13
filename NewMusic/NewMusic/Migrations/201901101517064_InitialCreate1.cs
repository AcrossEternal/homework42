namespace NewMusic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Collects",
                c => new
                    {
                        CollectID = c.Int(nullable: false, identity: true),
                        GenreID = c.Int(nullable: false),
                        AlbumID = c.Int(nullable: false),
                        MusciID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CollectID)
                .ForeignKey("dbo.Albums", t => t.AlbumID, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .ForeignKey("dbo.LoveMusics", t => t.MusciID, cascadeDelete: true)
                .Index(t => t.GenreID)
                .Index(t => t.AlbumID)
                .Index(t => t.MusciID);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.AlbumID);
            
            CreateTable(
                "dbo.LoveMusics",
                c => new
                    {
                        MusciID = c.Int(nullable: false, identity: true),
                        MusicName = c.String(),
                        MusicWhoName = c.String(),
                    })
                .PrimaryKey(t => t.MusciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Collects", "MusciID", "dbo.LoveMusics");
            DropForeignKey("dbo.Collects", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Collects", "AlbumID", "dbo.Albums");
            DropIndex("dbo.Collects", new[] { "MusciID" });
            DropIndex("dbo.Collects", new[] { "AlbumID" });
            DropIndex("dbo.Collects", new[] { "GenreID" });
            DropTable("dbo.LoveMusics");
            DropTable("dbo.Albums");
            DropTable("dbo.Collects");
            DropTable("dbo.Genres");
        }
    }
}
