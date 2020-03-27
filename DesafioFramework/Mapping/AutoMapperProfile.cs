using AutoMapper;
using DesafioFramework.Bll.resolvers;
using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using DesafioFramework.Resolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Bll.mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PaisDto, Pais>();
            CreateMap<Pais, PaisDto>();

            CreateMap<Estado, EstadoDto>();
            CreateMap<EstadoDto, Estado>();

            CreateMap<Cidade, CidadeDto>();
            CreateMap<CidadeDto, Cidade>();

            CreateMap<Paciente, PacienteDto>();
            CreateMap<PacienteDto, Paciente>();

            CreateMap<Paciente, PacienteViewDto>()
                .ForMember(dest => dest.fkidCidade, opt => opt.MapFrom<CidadeResolver>())
                .ForMember(dest => dest.fkidEstado, opt => opt.MapFrom<EstadoResolver>())
                .ForMember(dest => dest.fkidPais, opt => opt.MapFrom<PaisResolver>());

            CreateMap<Cidade, CidadeViewDto>()
                .ForMember(dest => dest.fkidEstado, opt => opt.MapFrom<EstadoCidadeResolver>());

            CreateMap<Estado, EstadoViewDto>()
                .ForMember(dest => dest.fkidPais, opt => opt.MapFrom<PaisCidadeResolver>());
        }
    }
}
