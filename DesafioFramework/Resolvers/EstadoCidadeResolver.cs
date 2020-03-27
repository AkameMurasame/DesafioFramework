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
    public class EstadoCidadeResolver : IValueResolver<Cidade, CidadeViewDto, string>
    {
        public readonly IEstadoBll _baseBll;

        public EstadoCidadeResolver(IEstadoBll baseBll)
        {
            _baseBll = baseBll;
        }

        public string Resolve(Cidade source, CidadeViewDto destination, string destMember, ResolutionContext context)
        {
            return _baseBll.GetById(source.fkidEstado).descricao;
        }
    }
}
