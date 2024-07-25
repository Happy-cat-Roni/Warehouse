﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseDAL.Entities
{
    public class Employees
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public double Salary { get; set; }
        public IEnumerable<WareHouse> WareHouses { get; set; } = null!;
    }
}