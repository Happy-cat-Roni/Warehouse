using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseAPI.Interface
{
    public interface IBaseDTO
    {
        public Guid? Id { get; set; }
    }
}
