﻿using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServices {
    public class CalculatorService : ICalculatorService {
        public double Add(double x, double y) {
            return x + y;
        }
    }
}
