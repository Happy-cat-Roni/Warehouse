using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseDAL.Entities;

namespace WareHouseDAL.Entities
{
    public class Director : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public IEnumerable<WareHouse> WareHouses { get; set; } = null!;

    }
}
