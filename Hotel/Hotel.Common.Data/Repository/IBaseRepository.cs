using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

 

namespace Hotel.Common.Data.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity">entidad con la que se va a trabajar</typeparam>
    /// <typeparam name="TType">id por donde se va a buscar</typeparam>
    public interface IBaseRepository <TEntity, TType> where TEntity : class
    {
       
        List<TEntity> GetAll();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetEntityBy(TType id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        bool Exist(Expression<Func<TEntity, bool>> filter); // verificar si existe un registro y hacer querrys sobre nuestros objetos digase entidades (LinkQuerry)...
    }
}
