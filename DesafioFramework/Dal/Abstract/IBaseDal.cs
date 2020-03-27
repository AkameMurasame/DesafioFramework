using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Abstract
{
    public interface IBaseDal<TEntity> where TEntity : BaseEntity
    {
        void InsertEntity(TEntity entityObject);
        void Delete(TEntity entity);
        TEntity GetById(long id);
        Task<IEnumerable<TEntity>> GetList();

        void UpdateEntity(TEntity entity);
    }
}
