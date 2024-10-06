using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WareHouseAPI.DTO;
using WareHouseBLL.Interface;
using WareHouseBLL.Mappers;
using WareHouseBLL.Models;

namespace WareHouseAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DirectorController : GenericController<DirectorModel, DirectorDTO>
    {
        public DirectorController(IGenericService<DirectorModel> genericService, IMapper mapper)
            : base(genericService, mapper) { }
    }

}
