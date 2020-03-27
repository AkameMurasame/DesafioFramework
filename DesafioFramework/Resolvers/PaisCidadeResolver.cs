using AutoMapper;
using DesafioFramework.Bll.Abstract;
using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Resolvers
{
    public class PaisCidadeResolver : IValueResolver<Estado, EstadoViewDto, string>
    {
        public readonly IPaisBll _baseBll;

        public PaisCidadeResolver(IPaisBll baseBll)
        {
            _baseBll = baseBll;
        }

        public string Resolve(Estado source, EstadoViewDto destination, string destMember, ResolutionContext context)
        {
            return _baseBll.GetById(source.fkidPais).Descricao;
        }
    }
}
