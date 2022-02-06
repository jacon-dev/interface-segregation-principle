using System;
using System.Collections.Generic;

namespace InterfaceSegregation
{
    public interface IEmployee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal FteAnnualSalary { get; set; }
        public List<string> FteBenefits { get; set; }
        public decimal CalculateSalary();

    }

    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal FteAnnualSalary { get; set; }
        public List<string> FteBenefits { get; set; }
        public decimal CalculateSalary()
        {
            return FteAnnualSalary / 12;
        }
    }
}