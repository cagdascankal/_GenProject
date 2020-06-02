using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.Entities.Concrete
{
    public class Employee:BaseDto
    {

        public Employee()
        {
            EmployeeAddress = new HashSet<EmployeeAddress>();
        }

        public string LastName { get; set; }
        public string FirsName { get; set; }
        public DateTime BirthData { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string MobilPhone { get; set; }

         
        public virtual IEnumerable<EmployeeAddress> EmployeeAddress { get; set; }
    }
}
