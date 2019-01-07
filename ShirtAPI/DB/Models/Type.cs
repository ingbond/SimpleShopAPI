﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Poseidon.Domain.Models.Base;
using ShirtAPI.DB.Base.Interfaces;

namespace ShirtAPI.Models
{
    public class Type : EntityBase<int>, IEntity<int>
    {
        public string Name { get; set; }
    }
}
