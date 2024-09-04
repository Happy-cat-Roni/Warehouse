using Microsoft.AspNetCore.Mvc;
using WareHouseAPI.DTO;
using WareHouseBLL.Interface;
using WareHouseBLL.Models;

namespace WareHouseAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class WareHouseController : GenericController<WareHouseModel, WareHouseDTO>
    {
        public WareHouseController(IGenericService<WareHouseModel> genericService)
            : base(genericService) { }
    }
}
