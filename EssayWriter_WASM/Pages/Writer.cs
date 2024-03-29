﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EssayWriter_WASM.Pages
{
    public class Writer
    {
        [Required]
        public string Thesis { get; set; }

        public string Structures { get; set; }

        [Required]
        [Range(0.00, 1.00)]
        public double temperature { get; set; }

        [Required]
        [Range(0.00, 1.00)]
        public double frequencyPenalty { get; set; }

        public string paragraphType { get; set; }
    }
}
