using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.Entities.Concrete
{
    public class EmployeeAddress : BaseDto
    {

        public EmployeeAddress()
        {

        }


        public string AddressName { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; } 
        public virtual long EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
