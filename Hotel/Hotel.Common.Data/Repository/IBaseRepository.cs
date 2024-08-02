
using System.Linq.Expressions;

 

namespace Hotel.Common.Data.Repository
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TType"></typeparam>
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        List<TEntity> GetAll();
       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        TEntity? GetEntityBy(TType id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Save(TEntity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);

        /*bool Exist(Expression<Func<TEntity, bool>> filter);*/ // verificar si existe un registro y hacer querrys sobre nuestros objetos digase entidades (LinkQuerry)...
    }
}
