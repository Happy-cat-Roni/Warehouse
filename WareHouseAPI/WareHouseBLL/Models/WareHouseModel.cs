using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseDAL.Entities;

namespace WareHouseBLL.Models
{
    public class WareHouseModel : BaseModel
    {
        public string Name { get; set; } = null!;
        public DirectorModel? Director { get; set; }
    }
}
