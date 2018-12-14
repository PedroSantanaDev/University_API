using System.Collections.Generic;

namespace University_API.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<CourseScheduled> CourseScheduleds { get; set; }

        /// <summary>
        /// Model Constructor
        /// </summary>
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }
    }
}