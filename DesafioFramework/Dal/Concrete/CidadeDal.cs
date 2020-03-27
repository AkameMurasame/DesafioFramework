using DesafioFramework.Dal.Abstract;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace DesafioFramework.Dal.Concrete
{
    public class CidadeDal : BaseDal<Cidade>, ICidadeDal
    {
        private readonly IConnectionDb _connectionDb;

        public CidadeDal(IConnectionDb connectionDb) : base(connectionDb)
        {
            _connectionDb = connectionDb;
        }

        public async Task<IEnumerable<Cidade>> GetCidadesByEstado(int idEstado)
        {
            using (var conn = _connectionDb.GetDbConnection())
            {
                string query = $@"SELECT * FROM Cidade WHERE fkidEstado = {idEstado}";
                return await conn.QueryAsync<Cidade>(query);
            }
        }
    }
}
