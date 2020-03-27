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
    public class PaisBll : BaseBll<Pais, PaisDto, PaisDto>, IPaisBll
    {
        private readonly IPaisDal _paisDal;
        private readonly IMapper _mapper;

        public PaisBll(IPaisDal paisDal, IBaseDal<Pais> baseDal, IMapper mapper) : base(baseDal, mapper)
        {
            _paisDal = paisDal;
            _mapper = mapper;
        }
    }
}
