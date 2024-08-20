using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseDAL.Entities;

namespace WareHouseDAL.Interface
{
    public interface IGenericRepository<TEntity> where TEntity :BaseEntity
    {
        Task<TEntity> Create(TEntity element, CancellationToken cancellationToken);
        Task Delete(string id, CancellationToken cancellationToken);
        Task<TEntity> Update(TEntity element, CancellationToken cancellationToken);
        Task<List<TEntity>> GetAll(CancellationToken cancellationToken);
        Task<TEntity?> GetById(string id, CancellationToken cancellationToken);
    }
}
