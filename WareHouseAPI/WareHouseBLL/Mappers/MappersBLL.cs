using AutoMapper;
using WareHouseBLL.Models;
using WareHouseDAL.Entities;

namespace WareHouseBLL.Mappers
{
    public class MappersBLL : Profile
    {
        public MappersBLL()
        {
            CreateMap<WareHouseModel, WareHouse>().ReverseMap();
            CreateMap<DirectorModel, Director>().ReverseMap();
            CreateMap<EmployeesModel, Employees>().ReverseMap();
        }
    }
}
