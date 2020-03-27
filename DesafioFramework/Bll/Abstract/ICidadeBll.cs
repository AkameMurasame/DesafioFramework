using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Bll.Abstract
{
    public interface ICidadeBll : IBaseBll<Cidade, CidadeDto, CidadeViewDto>
    {
        Task<List<CidadeDto>> GetCidadesByEstado(int idEstado);
    }
}
