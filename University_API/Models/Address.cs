using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_API.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }

        public Address()
        {
            Students = new HashSet<Student>();
            Staffs = new HashSet<Staff>();
        }
    }
}