using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace University_API.Models
{
    public class UniversityContext : DbContext { 
        public UniversityContext() : base("UniversityContext") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseScheduled> CourseScheduleds { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}