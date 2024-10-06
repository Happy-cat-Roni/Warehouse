using AutoMapper;
using WareHouseAPI.DTO;
using WareHouseBLL.Models;

namespace WareHouseAPI.Mappers
{
    public class MappersAPI : Profile 
    {
        public MappersAPI()
        {
            CreateMap<WareHouseDTO, WareHouseModel>().ReverseMap();
            CreateMap<DirectorDTO, DirectorModel>().ReverseMap();
            CreateMap<EmployeesDTO, EmployeesModel>().ReverseMap();
        }
    }
}
