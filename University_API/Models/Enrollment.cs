﻿namespace University_API.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }

    }
}