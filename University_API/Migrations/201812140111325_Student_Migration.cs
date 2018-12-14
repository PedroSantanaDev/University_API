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
                DateOfBirth = DateTime.Parse("2000-09-01")
            };
            context.Students.Add(student);
            context.SaveChanges();

           
            var student2 = new Student
            {
                LastName = "Lopez",
                FirstName = "Maria",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("1995-10-01")
            };
            context.Students.Add(student2);
            context.SaveChanges();

            var student3 = new Student
            {
                LastName = "Doe",
                FirstName = "Marie",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("1998-09-09")
            };
            context.Students.Add(student3);
            context.SaveChanges();

            var student4 = new Student
            {
                LastName = "Khan",
                FirstName = "Ali",
                Gender = "Male",
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
