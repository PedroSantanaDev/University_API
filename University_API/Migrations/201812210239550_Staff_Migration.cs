namespace University_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using University_API.Models;

    public partial class Staff_Migration : DbMigration
    {
        public override void Up()
        {
            var context = new UniversityContext();
            var staff = new Staff
            {
                FirsName = "Mike",
                LastName = "Smith",
                Title = "Teacher",
                DateOfBirth = DateTime.Parse("1980-06-09"),
                HireDate = DateTime.Parse("2017-01-10"),
                PhoneNumber = "289 584-4875",
                AddressId = 2
            };
            context.Staffs.Add(staff);
            context.SaveChanges();

            var staff2 = new Staff
            {
                FirsName = "Jane",
                LastName = "Smith",
                Title = "Teacher",
                DateOfBirth = DateTime.Parse("1985-06-09"),
                HireDate = DateTime.Parse("2016-01-10"),
                PhoneNumber = "249 845-5487",
                AddressId = 1
            };
            context.Staffs.Add(staff2);
            context.SaveChanges();

            var staff3 = new Staff
            {
                FirsName = "Alex",
                LastName = "Jee",
                Title = "Accountant",
                DateOfBirth = DateTime.Parse("1975-02-05"),
                HireDate = DateTime.Parse("2010-01-10"),
                PhoneNumber = "249 457-5689",
                AddressId = 1
            };
            context.Staffs.Add(staff3);
            context.SaveChanges();


        }
        
        public override void Down()
        {
        }
    }
}
