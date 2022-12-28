﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelShade.ModelDb
{
    internal class Logs
    {
        [Key]
        public long IdLog { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }
    }
}
