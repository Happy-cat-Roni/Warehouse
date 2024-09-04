using WareHouseAPI.DTO;
using WareHouseBLL.Models;

namespace WareHouseAPI.DTO
{
    public class WareHouseDTO : BaseDTO
    {
        public string Name { get; set; } = null!;
        public DirectorDTO? Director { get; set; }
    }
}
