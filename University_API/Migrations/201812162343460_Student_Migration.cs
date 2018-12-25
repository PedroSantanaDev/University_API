namespace University_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using University_API.Models;

    public partial class Student_Migration : DbMigration
    {
        public override void Up()
        {
            var context = new UniversityContext();

            var student = new Student
            {
                LastName = "Khan",
                FirstName = "Ali",
                Gender = "Male",
                EnrollmentDate = DateTime.Parse("2014-08-07"),
                DateOfBirth = DateTime.Parse("2000-09-01")
            };
            context.Students.Add(student);
            context.SaveChanges();


            var student2 = new Student
            {
                LastName = "Lopez",
                FirstName = "Maria",
                Gender = "Female",
                EnrollmentDate = DateTime.Parse("2018-06-09"),
                DateOfBirth = DateTime.Parse("1995-10-01")
            };
            context.Students.Add(student2);
            context.SaveChanges();

            var student3 = new Student
            {
                LastName = "Doe",
                FirstName = "Marie",
                Gender = "Female",
                EnrollmentDate = DateTime.Parse("2015-08-05"),
                DateOfBirth = DateTime.Parse("1998-09-09")
            };
            context.Students.Add(student3);
            context.SaveChanges();

            var student4 = new Student
            {
                LastName = "Khan",
                FirstName = "Ali",
                Gender = "Male",
                EnrollmentDate = DateTime.Parse("2003-03-05"),
                DateOfBirth = DateTime.Parse("2002-03-05")
            };
            context.Students.Add(student4);
            context.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
