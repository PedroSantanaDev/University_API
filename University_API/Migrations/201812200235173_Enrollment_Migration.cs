namespace University_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using University_API.Models;

    public partial class Enrollment_Migration : DbMigration
    {
        public override void Up()
        {
            var context = new UniversityContext();

            var enrollment = new Enrollment
            {
                CourseID = 1,
                StudentID = 1
            };
            context.Enrollments.Add(enrollment);
            context.SaveChanges();

            var enrollment2 = new Enrollment
            {
                CourseID = 2,
                StudentID = 2
            };
            context.Enrollments.Add(enrollment2);
            context.SaveChanges();

            var enrollment3 = new Enrollment
            {
                CourseID = 3,
                StudentID = 3
            };
            context.Enrollments.Add(enrollment3);
            context.SaveChanges();

            var enrollment4 = new Enrollment
            {
                CourseID = 4,
                StudentID = 4
            };
            context.Enrollments.Add(enrollment);
            context.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
