using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.Business.Abstract
{
    public interface IEmployeeAddressService
    {
        void Add(EmployeeAddress item);
        void Update(EmployeeAddress item);
        List<EmployeeAddress> GetAll();
    }
}
