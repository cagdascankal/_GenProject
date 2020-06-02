using GeneralProject.Core.Enties;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GeneralProject.Core.DataAccess
{
    public interface IEntityRepostory<T> where T : class, IEntity, new()
    {

        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList(Expression<Func<T, bool>> filter=null);

        void Add(T Entity);
        void Update(T Entity); 
        void delete(T Entity);



    }
}
