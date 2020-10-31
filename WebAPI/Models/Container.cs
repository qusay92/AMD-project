﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Container : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }

    }
}
