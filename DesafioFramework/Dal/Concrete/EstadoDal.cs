using DesafioFramework.Dal.Abstract;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace DesafioFramework.Dal.Concrete
{
    public class EstadoDal : BaseDal<Estado>, IEstadoDal
    {
        private readonly IConnectionDb _connectionDb;

        public EstadoDal(IConnectionDb connectionDb) : base(connectionDb)
        {
            _connectionDb = connectionDb;
        }

        public async Task<IEnumerable<Estado>> GetEstadosByPais(int idPais)
        {
            using(var conn = _connectionDb.GetDbConnection())
            {
                string query = @$"SELECT * FROM Estado WHERE fkidPais = {idPais}";
                return await conn.QueryAsync<Estado>(query);
            }
        }
    }
}
