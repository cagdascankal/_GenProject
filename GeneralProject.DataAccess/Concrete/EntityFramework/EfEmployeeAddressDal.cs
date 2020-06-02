using GeneralProject.Core.DataAccess.EntityFramework;
using GeneralProject.DataAccess.Abstract;
using GeneralProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace GeneralProject.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeAddressDal : EFEntityRepostoryBase<EmployeeAddress, GeneralContext>, IEmployeeAddressDal
    {
         
    }
}
