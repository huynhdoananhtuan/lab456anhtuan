namespace tuận.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigra : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attedances",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendeeId })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId)
                .Index(t => t.AttendeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attedances", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Attedances", "AttendeeId", "dbo.AspNetUsers");
            DropIndex("dbo.Attedances", new[] { "AttendeeId" });
            DropIndex("dbo.Attedances", new[] { "CourseId" });
            DropTable("dbo.Attedances");
        }
    }
}
