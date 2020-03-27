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
    public class CidadeBll : BaseBll<Cidade, CidadeDto, CidadeViewDto>, ICidadeBll
    {
        private readonly IMapper _mapper;
        private readonly ICidadeDal _cidadeDal;

        public CidadeBll(ICidadeDal cidadeDal, IBaseDal<Cidade> baseDal, IMapper mapper) : base(baseDal, mapper)
        {
            _cidadeDal = cidadeDal;
            _mapper = mapper;
        }

        public async Task<List<CidadeDto>> GetCidadesByEstado(int idEstado)
        {
            var entity = await _cidadeDal.GetCidadesByEstado(idEstado);
            var basesdto = _mapper.Map<IEnumerable<CidadeDto>>(entity);
            return basesdto.ToList();
        }
    }
}
