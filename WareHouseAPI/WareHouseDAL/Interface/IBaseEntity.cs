﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseDAL.Interface
{
    public interface IBaseEntity
    {
        public string Id { get; set; } = null!;
    }
}
