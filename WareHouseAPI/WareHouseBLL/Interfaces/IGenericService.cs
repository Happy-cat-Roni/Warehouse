using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseBLL.Models;
using WareHouseDAL.Entities;

namespace WareHouseBLL.Interface
{
    public interface IGenericService<TModel> where TModel : BaseModel
    {
        Task Create(TModel model, CancellationToken cancellationToken);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task Update(TModel model, CancellationToken cancellationToken);
        Task<List<TModel>> GetAll(CancellationToken cancellationToken);
        Task<TModel?> GetById(Guid id, CancellationToken cancellationToken);
    }
}
