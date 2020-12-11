﻿using IRF_Project_JJEZ57.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_JJEZ57.Entities
{
    public class MercedesProduction : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Mercedes();
        }
    }
}
