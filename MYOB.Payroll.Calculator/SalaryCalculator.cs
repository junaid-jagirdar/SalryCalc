using System;

namespace MYOB.Payroll.Calculator
{
    public class SalaryCalculator
    {

        private readonly ITaxCalaculator _taxCalaculator;
        private readonly ISuperCalculator _superCalaculator;


        public SalaryCalculator(ITaxCalaculator taxCalaculator,ISuperCalculator superCalculator)
        {
            _taxCalaculator = taxCalaculator;
            _superCalaculator = superCalculator;
        }

        public Salary CalculateSalary(decimal grossSalary,decimal superPercantage)
        {
            Salary salary = new Salary();
            var grossMonthlySalary = Math.Round(grossSalary / 12, MidpointRounding.AwayFromZero);
            salary.IncomeTax = _taxCalaculator.CalculateTax(grossMonthlySalary);
            var netIncome = grossMonthlySalary - salary.IncomeTax;
            salary.Super = _superCalaculator.CalculateSuper(netIncome, superPercantage);
            salary.NetIncome = Math.Round(netIncome, MidpointRounding.AwayFromZero);
            salary.GrossSalary = grossMonthlySalary;
            return salary;
        }

  
    }
}
