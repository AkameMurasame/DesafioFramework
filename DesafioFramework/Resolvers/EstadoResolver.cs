﻿using AutoMapper;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Bll.resolvers
{
    public class EstadoResolver : IValueResolver<Paciente, PacienteViewDto, string>
    {
        public readonly IEstadoBll _baseBll;

        public EstadoResolver(IEstadoBll baseBll)
        {
            _baseBll = baseBll;
        }

        public string Resolve(Paciente source, PacienteViewDto destination, string destMember, ResolutionContext context)
        {
            return _baseBll.GetById(source.fkidEstado).descricao;
        }
    }
}
