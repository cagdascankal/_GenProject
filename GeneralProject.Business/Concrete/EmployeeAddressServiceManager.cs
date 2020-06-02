using GeneralProject.Business.Abstract;
using GeneralProject.DataAccess.Abstract;
using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.Business.Concrete
{
    public class EmployeeAddressServiceManager : IEmployeeAddressService
    {
        private IEmployeeAddressDal _IEmployeeDal;
        public EmployeeAddressServiceManager(IEmployeeAddressDal IEmployeeAddressDal)
        {
            _IEmployeeDal = IEmployeeAddressDal;
        }
        public void Add(EmployeeAddress item)
        {
            _IEmployeeDal.Add(item);
        }

        public List<EmployeeAddress> GetAll()
        {
           return _IEmployeeDal.GetList();
        }

        public void Update(EmployeeAddress item)
        {
            _IEmployeeDal.Update(item);
        }
    }
}
