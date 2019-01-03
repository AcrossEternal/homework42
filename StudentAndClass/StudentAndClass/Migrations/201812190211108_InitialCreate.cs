namespace StudentAndClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Long(nullable: false, identity: true),
                        ClassName = c.String(),
                        StudentsId = c.Long(nullable: false),
                        Class_ClassId = c.Long(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .Index(t => t.Class_ClassId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentsId = c.Long(nullable: false, identity: true),
                        StudentsName = c.String(),
                        Sex = c.String(),
                        ClassName = c.String(),
                        Class_ClassId = c.Long(),
                    })
                .PrimaryKey(t => t.StudentsId)
                .ForeignKey("dbo.Classes", t => t.Class_ClassId)
                .Index(t => t.Class_ClassId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Class_ClassId", "dbo.Classes");
            DropForeignKey("dbo.Classes", "Class_ClassId", "dbo.Classes");
            DropIndex("dbo.Students", new[] { "Class_ClassId" });
            DropIndex("dbo.Classes", new[] { "Class_ClassId" });
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
