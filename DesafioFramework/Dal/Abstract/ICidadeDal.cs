using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Dal.Abstract
{
    public interface ICidadeDal : IBaseDal<Cidade>
    {
        public Task<IEnumerable<Cidade>> GetCidadesByEstado(int idEstado);
    }
}
