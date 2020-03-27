using DesafioFramework.Models.Dto;
using DesafioFramework.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFramework.Bll.Abstract
{
    public interface IBaseBll<TEntity, TDto, TView> where TEntity : BaseEntity where TDto : BaseDto
    {
        void Insert(TDto dto);
        TDto GetById(long id);
        TView GetByIdView(long id);
        Task<List<TView>> GetList();
        void Delete(long id);
        void Edit(TDto dto);
    }
}
