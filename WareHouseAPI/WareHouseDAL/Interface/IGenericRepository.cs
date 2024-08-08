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
        Task Delete(int id, CancellationToken cancellationToken);
    }
}
