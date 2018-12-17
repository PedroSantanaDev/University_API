using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_API.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
    }
}