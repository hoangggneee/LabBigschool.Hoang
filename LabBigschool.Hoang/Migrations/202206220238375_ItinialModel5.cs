namespace LabBigschool.Hoang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItinialModel5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "CourseId", "dbo.Courses");
            DropIndex("dbo.Attendances", new[] { "CourseId" });
            DropTable("dbo.Attendances");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendeeId });
            
            CreateIndex("dbo.Attendances", "CourseId");
            AddForeignKey("dbo.Attendances", "CourseId", "dbo.Courses", "Id");
        }
    }
}
