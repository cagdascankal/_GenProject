using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GeneralProject.Business.Abstract
{
    public interface IEmployeeAddressService
    {
        void Add(EmployeeAddress item);
        void Update(EmployeeAddress item);
        List<EmployeeAddress> GetAll();

        EmployeeAddress Get(Expression<Func<EmployeeAddress, bool>> filter);
    }
}
