using WareHouseAPI.DTO;

namespace CaffeAPI.DTO
{
    public class DirectorDTO : BaseDTO
    {
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
