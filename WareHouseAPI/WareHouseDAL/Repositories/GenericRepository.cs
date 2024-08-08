using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseDAL.Entities;
using WareHouseDAL.Interface;

namespace WareHouseDAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext dbContext;
        protected readonly DbSet<TEntity> dbSet;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            this.dbContext = applicationDbContext;
            dbSet = applicationDbContext.Set<TEntity>();
        }

        public async Task<TEntity> Create(TEntity element, CancellationToken cancellationToken)
        {
            dbSet.Add(element);
            await dbContext.SaveChangesAsync(cancellationToken);

            return element;
        }

        public async Task Delete(int id, CancellationToken cancellationToken)
        {
            var element = await dbSet.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

            if (element != null)
            {
                dbSet.Remove(element);
                await dbContext.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
