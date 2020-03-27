using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Abstract
{
    public interface IEstadoDal : IBaseDal<Estado>
    {
        public Task<IEnumerable<Estado>> GetEstadosByPais(int idPais);
    }
}
