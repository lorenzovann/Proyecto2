using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Common.Data.Repository
{
    internal interface IBaseRepository <TEntity, TType> where TEntity : class
    {
       List<TEntity> GetAll();
       TEntity GetAllBy(TType id);
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        bool Exist(Expression<Func<TEntity, bool>> filter); // verificar si existe un registro y hacer querrys sobre nuestros objetos digase entidades (LinkQuerry)...
    }
}
