﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingListToClass
{
    public class Car
    {
        public string Owner { get; set; }
        public BrandType BrandType { get; set; }
        public CarType Type { get; set; }
    }
}
