﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseBLL.Models
{
    public class DirectorModel : BaseModel
    {
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
