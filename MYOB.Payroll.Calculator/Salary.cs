﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MYOB.Payroll.Calculator
{
   public class Salary
    {
        public decimal GrossSalary { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal NetIncome { get; set; }
        public decimal Super { get; set; }
    }
}
