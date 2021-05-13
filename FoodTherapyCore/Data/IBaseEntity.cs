﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTherapyCore.Data
{
    public interface IBaseEntity
    {
        int ID { get; set; }

        DateTime LastDate { get; set; }
    }
}
