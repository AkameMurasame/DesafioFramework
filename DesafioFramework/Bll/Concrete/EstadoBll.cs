using AutoMapper;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Dal.Abstract;
using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Bll.Concrete
{
    public class EstadoBll : BaseBll<Estado, EstadoDto, EstadoViewDto>, IEstadoBll
    {
        private readonly IMapper _mapper;
        private readonly IEstadoDal _estadoDal;

        public EstadoBll(IEstadoDal estadoDal, IBaseDal<Estado> baseDal, IMapper mapper) : base(estadoDal, mapper)
        {
            _mapper = mapper;
            _estadoDal = estadoDal;
        }

        public async Task<List<EstadoDto>> GetEstadosByPais(int idPais)
        {
            var entity = await _estadoDal.GetEstadosByPais(idPais);
            var basesdto = _mapper.Map<IEnumerable<EstadoDto>>(entity);
            return basesdto.ToList();
        }
    }
}
