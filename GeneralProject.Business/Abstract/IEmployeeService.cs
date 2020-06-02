using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.Business.Abstract
{
    public interface IEmployeeService
    {
        void Add(Employee item);
        void Update(Employee item); 
        List<Employee> GetAll();



    }
}
