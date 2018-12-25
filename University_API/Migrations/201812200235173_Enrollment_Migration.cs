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
        }
        
        public override void Down()
        {
        }
    }
}
