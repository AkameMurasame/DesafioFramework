using AutoMapper;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioFramework.Dal.Abstract;

namespace DesafioFramework.Bll.Concrete
{
    public class PacienteBll : BaseBll<Paciente, PacienteDto, PacienteViewDto>, IPacienteBll
    {
        private readonly IMapper _mapper;
        private readonly IPacienteDal _pacienteDal;

        public PacienteBll(IPacienteDal pacienteDal, IBaseDal<Paciente> baseDal, IMapper mapper) : base(baseDal, mapper)
        {
            _mapper = mapper;
            _pacienteDal = pacienteDal;
        }
    }
}
