using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseDAL.Interface;

namespace WareHouseDAL.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public Guid? Id { get; set; }
    }
}
