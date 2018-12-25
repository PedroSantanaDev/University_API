/*
 * @Author: Pedro Santana
 * @Date: 12/25/2018
 * @Program: University API
 * @Github : https://github.com/PedroSantanaDev
 * 
 * @Purpose: Course Registrations migration
 */

namespace University_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using University_API.Models;

    public partial class Course_Registration_Migratin : DbMigration
    {
        public override void Up()
        {
            var context = new UniversityContext();

            var courseRegistration = new CourseRegistration
            {
                StudentId = 1,
                CourseScheduledId = 1
            };
            context.CourseRegistrations.Add(courseRegistration);
            context.SaveChanges();

            var courseRegistration2 = new CourseRegistration
            {
                StudentId = 3,
                CourseScheduledId = 4
            };
            context.CourseRegistrations.Add(courseRegistration2);
            context.SaveChanges();

            var courseRegistration3 = new CourseRegistration
            {
                StudentId = 2,
                CourseScheduledId = 3
            };
            context.CourseRegistrations.Add(courseRegistration3);
            context.SaveChanges();

        }

        public override void Down()
        {
        }
    }
}
