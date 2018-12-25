using System;
using System.Collections.Generic;

namespace University_API.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? EnrollmentDate { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }
    }
}