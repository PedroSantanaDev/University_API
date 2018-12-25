using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_API.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public decimal Budget { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Department()
        {
            this.Courses = new HashSet<Course>();
        }
    }
}