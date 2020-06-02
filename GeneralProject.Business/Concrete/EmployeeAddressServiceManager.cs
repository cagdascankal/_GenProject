using GeneralProject.Business.Abstract;
using GeneralProject.DataAccess.Abstract;
using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GeneralProject.Business.Concrete
{
    public class EmployeeAddressServiceManager : IEmployeeAddressService
    {
        private IEmployeeAddressDal _IEmployeeAddressDal;
        public EmployeeAddressServiceManager(IEmployeeAddressDal IEmployeeAddressDal)
        {
            _IEmployeeAddressDal = IEmployeeAddressDal;
        }
        public void Add(EmployeeAddress item)
        {
            _IEmployeeAddressDal.Add(item);
        }

        public EmployeeAddress Get(Expression<Func<EmployeeAddress, bool>> filter)
        {
            return _IEmployeeAddressDal.Get(filter);
        }

        public List<EmployeeAddress> GetAll()
        {
            return _IEmployeeAddressDal.GetList();
        }

        public void Update(EmployeeAddress item)
        {
            _IEmployeeAddressDal.Update(item);
        }


    }
}
