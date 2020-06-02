using GeneralProject.Business.Abstract;
using GeneralProject.DataAccess.Abstract;
using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.Business.Concrete
{
    public class EmployeeServiceManager : IEmployeeService
    {

        private IEmployeeDal _IEmployeeDal; 
        public EmployeeServiceManager(IEmployeeDal IEmployeeDal)
        {
            _IEmployeeDal = IEmployeeDal;
        }

        public void Add(Employee item)
        {
            _IEmployeeDal.Add(item);
        }

        public List<Employee> GetAll()
        {
            return _IEmployeeDal.GetList();
        }

        public void Update(Employee item)
        {
            
            _IEmployeeDal.Update(item);
        }
    }
}
