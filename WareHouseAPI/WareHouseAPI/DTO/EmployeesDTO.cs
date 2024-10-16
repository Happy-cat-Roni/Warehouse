﻿using WareHouseAPI.DTO;

namespace WareHouseAPI.DTO
{
    public class EmployeesDTO : BaseDTO
    {
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public double Salary { get; set; }
    }
}
