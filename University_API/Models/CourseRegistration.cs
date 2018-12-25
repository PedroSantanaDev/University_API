/*
 * @Author: Pedro Santana
 * @Date: 12/25/2018
 * @Program: University API
 * @Github : https://github.com/PedroSantanaDev
 * 
 * @Purpose: CourseRegistration model class for course registration link
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_API.Models
{
    public class CourseRegistration
    {
        public int CourseRegistrationId { get; set; }
        public int StudentId { get; set; }
        public int CourseScheduledId { get; set; }
    }
}