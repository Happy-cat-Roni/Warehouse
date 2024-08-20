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

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task Create(TModel model, CancellationToken cancellationToken)
        {
            var entity = new TEntity
            {
                Id = model.Id
            };

            await _genericRepository.Create(entity, cancellationToken);
        }

        public async Task Delete(string id, CancellationToken cancellationToken)
        {
            await _genericRepository.Delete(id, cancellationToken);
        }

        public async Task Update(TModel model, CancellationToken cancellationToken)
        {
            var entity = new TEntity { Id = model.Id };

            await _genericRepository.Update(entity, cancellationToken);
        }

        public async Task<List<TModel>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _genericRepository.GetAll(cancellationToken);

            return result.Select(x => new TModel { Id = x.Id }).ToList();
        }

        public async Task<TModel?> GetById(string id, CancellationToken cancellationToken)
        {
            var result = await _genericRepository.GetById(id, cancellationToken);

            if (result == null)
                throw new Exception();

            return new TModel
            {
                Id = result.Id
            };
        }
    }
}
