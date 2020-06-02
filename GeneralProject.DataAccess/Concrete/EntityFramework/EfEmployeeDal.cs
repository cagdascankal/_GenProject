using GeneralProject.Core.DataAccess.EntityFramework;
using GeneralProject.DataAccess.Abstract;
using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralProject.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal:EFEntityRepostoryBase<Employee,GeneralContext>,IEmployeeDal
    {




    }
}
