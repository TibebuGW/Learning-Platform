﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teaching.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte[] ImageFile { get; set; }
    }
}