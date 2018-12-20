namespace University_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using University_API.Models;

    public partial class Address_Migration : DbMigration
    {
        public override void Up()
        {
            var context = new UniversityContext();

            var address = new Address
            {
                Address1 = "10 Scott Ave",
                Address2 = "20 Mark street",
                City = "Hamilton",
                PostalCode = "L8C 5R3",
                Province = "ON"
            };
            context.Addresses.Add(address);
            context.SaveChanges();

            var address2 = new Address
            {
                Address1 = "25 James street",
                Address2 = "30 James street",
                City = "Burlington",
                PostalCode = "H8W 9H4",
                Province = "ON"
            };
            context.Addresses.Add(address2);
            context.SaveChanges();

            var address3 = new Address
            {
               Address1 = "95 Fennell",
               City = "Hamilton",
               PostalCode = "L9P 3H5",
               Province = "ON"
            };
            context.Addresses.Add(address3);
            context.SaveChanges();

            var address4 = new Address
            {
                Address1 = "21 Port Street",
                City = "Hamilton",
                PostalCode = "P9H 9Y4",
                Province = "ON"
            };

            context.Addresses.Add(address4);
            context.SaveChanges();
        }
        
        public override void Down()
        {
        }
    }
}
