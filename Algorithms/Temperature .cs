﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Temperature
    {
        public void CelsiusToFahrenheit()
        {
            double C, F;

            F = 212;
            C= (F - 32) * 5 / 9;
            Console.WriteLine("The Celsius {0}",C);
            Console.ReadLine();
        }
    }
}
