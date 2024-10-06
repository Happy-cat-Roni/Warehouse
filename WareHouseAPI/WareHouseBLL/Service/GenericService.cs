using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseBLL.Interface;
using WareHouseBLL.Models;
using WareHouseDAL.Entities;
using WareHouseDAL.Interface;

namespace WareHouseBLL.Service
{
    public class GenericService<TModel, TEntity> : IGenericService<TModel>
        where TModel : BaseModel, new()
        where TEntity : BaseEntity, new()
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task Create(TModel model, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(model);

            await _genericRepository.Create(entity, cancellationToken);
        }

        public async Task Delete(Guid id, CancellationToken cancellationToken)
        {
            await _genericRepository.Delete(id, cancellationToken);
        }

        public async Task Update(TModel model, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(model);

            await _genericRepository.Update(entity, cancellationToken);
        }

        public async Task<List<TModel>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _genericRepository.GetAll(cancellationToken);

            return _mapper.Map<List<TModel>>(result);
        }

        public async Task<TModel?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _genericRepository.GetById(id, cancellationToken);

            if (result == null)
                throw new Exception();

            return _mapper.Map<TModel>(result);
        }
    }
}
