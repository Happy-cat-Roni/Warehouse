using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseDAL.Entities
{
    public class WareHouse : BaseEntity
    {
        public string Name { get; set; } = null!;
        public Director? Director { get; set; }
        public IEnumerable<Employees>? Employees { get; set; }
    }
}
