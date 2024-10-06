using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouseBLL.Interface;

namespace WareHouseBLL.Models
{
    public class BaseModel : IBaseModel
    {
        public Guid? Id { get; set; }

    }
}
