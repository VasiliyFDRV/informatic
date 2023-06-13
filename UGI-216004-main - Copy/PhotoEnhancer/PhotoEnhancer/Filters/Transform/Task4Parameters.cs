﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class Task4Parameters : IParameters
    {
        [ParameterInfo(Name = "Сдвиг в %",
                    MinValue = 0,
                    MaxValue = 100,
                    DefaultValue = 0,
                    Increment = 5)]
        public double NInPerents { get; set; }
    }
}
