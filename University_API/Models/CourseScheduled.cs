using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_API.Models
{
    public class CourseScheduled
    {
        public int CourseScheduledId { get; set; }
        public int CourseId { get; set; }
        public DateTime? DateTime { get; set; }
    }
}