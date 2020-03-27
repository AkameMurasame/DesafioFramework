using Dapper.Contrib.Extensions;
using DesafioFramework.Dal.Abstract;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Concrete
{
    public class BaseDal<TEntity> : IBaseDal<TEntity> where TEntity : BaseEntity
    {

        private readonly IConnectionDb _connectionDb;

        public BaseDal(IConnectionDb connectionDb)
        {
            _connectionDb = connectionDb;
        }

        public void Delete(TEntity entity)
        {

            using (var conn = _connectionDb.GetDbConnection())
            {
                conn.Delete<TEntity>(entity);
            }
        }

        public TEntity GetById(long id)
        {
            using (var conn = _connectionDb.GetDbConnection())
            {
                return conn.Get<TEntity>(id);
            }
        }

        public async Task<IEnumerable<TEntity>> GetList()
        {
            using (var conn = _connectionDb.GetDbConnection())
            {
                TableAttribute tableAttribute = (TableAttribute)Attribute.GetCustomAttribute(typeof(TEntity), typeof(TableAttribute));
                //string query = @$"SELECT * FROM {tableAttribute.Name}";
                return await conn.GetAllAsync<TEntity>();
            }
        }

        public void InsertEntity(TEntity entityObject)
        {
            using (var conn = _connectionDb.GetDbConnection())
            {
                conn.Insert<TEntity>(entityObject);
            }
        }

        public void UpdateEntity(TEntity entity)
        {
            using (var conn = _connectionDb.GetDbConnection())
            {
                conn.Update<TEntity>(entity);
            }
        }
    }
}
