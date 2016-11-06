namespace StudentSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Materials = c.String(),
                        Status = c.Int(nullable: false),
                        StudetsInCourse_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudetsInCourses", t => t.StudetsInCourse_Id)
                .Index(t => t.StudetsInCourse_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                        HomeworkId = c.Guid(nullable: false),
                        Homework_Id = c.Int(),
                        Course_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Homework", t => t.Homework_Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Homework_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Homework",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        TimeSent = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudetsInCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "StudetsInCourse_Id", "dbo.StudetsInCourses");
            DropForeignKey("dbo.Students", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Students", "Homework_Id", "dbo.Homework");
            DropIndex("dbo.Students", new[] { "Course_Id" });
            DropIndex("dbo.Students", new[] { "Homework_Id" });
            DropIndex("dbo.Courses", new[] { "StudetsInCourse_Id" });
            DropTable("dbo.StudetsInCourses");
            DropTable("dbo.Homework");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
