using System;
using System.Collections.Generic;
using University_API.Models;

namespace University_API.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int AddressId { get; set; }
    }
}