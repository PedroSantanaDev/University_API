namespace University_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using University_API.Models;

    public partial class Course_Migration : DbMigration
    {
        public override void Up()
        {
            var context = new UniversityContext();

            var course = new Course
            {
                CourseName = "Statistics",
                Credits = 4
            };

            context.Courses.Add(course);
            context.SaveChanges();

            var course2 = new Course
            {
                CourseName = "R Programming",
                Credits = 5
            };

            context.Courses.Add(course2);
            context.SaveChanges();

            var course3 = new Course
            {
                CourseName = "C# Programming",
                Credits = 4
            };

            context.Courses.Add(course3);
            context.SaveChanges();

            var course4 = new Course
            {
                CourseName = "C++ Programming",
                Credits = 5
            };

            context.Courses.Add(course4);
            context.SaveChanges();


            var course5 = new Course
            {
                CourseName = "Visual Basic Programming",
                Credits = 5
            };

            context.Courses.Add(course5);
            context.SaveChanges();

        }
        
        public override void Down()
        {
        }
    }
}
