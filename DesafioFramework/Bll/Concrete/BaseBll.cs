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
    public class BaseBll<TEntity, TDto, TView> : IBaseBll<TEntity, TDto, TView> where TEntity : BaseEntity where TDto : BaseDto
    {
        private readonly IMapper _mapper;
        private readonly IBaseDal<TEntity> _baseDal;

        public BaseBll(IBaseDal<TEntity> baseDal, IMapper mapper)
        {
            _baseDal = baseDal;
            _mapper = mapper;
        }

        public void Delete(long id)
        {
            var entity = _baseDal.GetById(id);
            _baseDal.Delete(entity);
        }

        public void Edit(TDto dto)
        {
            var entityObject = _mapper.Map<TEntity>(dto);
            _baseDal.UpdateEntity(entityObject);
        }

        public TDto GetById(long id)
        {
            var entity = _baseDal.GetById(id);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }

        public TView GetByIdView(long id)
        {
            var entity = _baseDal.GetById(id);
            var dto = _mapper.Map<TView>(entity);
            return dto;
        }

        public async Task<List<TView>> GetList()
        {
            var basemailings = await _baseDal.GetList();
            var basesdto = _mapper.Map<IEnumerable<TView>>(basemailings);
            return basesdto.ToList();
        }

        public void Insert(TDto dto)
        {
            var entityObject = _mapper.Map<TEntity>(dto);
            _baseDal.InsertEntity(entityObject);
        }
    }
}
