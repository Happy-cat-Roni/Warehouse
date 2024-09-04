using Microsoft.AspNetCore.Mvc;
using WareHouseAPI.DTO;
using WareHouseBLL.Interface;
using WareHouseBLL.Models;

namespace WareHouseAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : GenericController<EmployeesModel, EmployeesDTO>
    {
        public EmployeesController(IGenericService<EmployeesModel> genericService)
            : base(genericService) { }
    }
}
