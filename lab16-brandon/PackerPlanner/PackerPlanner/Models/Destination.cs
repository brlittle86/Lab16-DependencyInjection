﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackerPlanner.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string Country { get; set; }
        public List<string> RequiredItems { get; set; }
    }
}
