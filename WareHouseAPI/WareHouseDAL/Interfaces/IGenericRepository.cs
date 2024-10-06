using WareHouseDAL.Entities;

namespace WareHouseDAL.Interface
{
    public interface IGenericRepository<TEntity> where TEntity :BaseEntity
    {
        Task<TEntity> Create(TEntity element, CancellationToken cancellationToken);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task<TEntity> Update(TEntity element, CancellationToken cancellationToken);
        Task<List<TEntity>> GetAll(CancellationToken cancellationToken);
        Task<TEntity?> GetById(Guid id, CancellationToken cancellationToken);
    }
}
