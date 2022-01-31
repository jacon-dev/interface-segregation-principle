using System;
using System.Collections.Generic;

namespace InterfaceSegregation
{
    public interface IEmployee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal AnnualSalary { get; set; }
        public List<string> Benefits { get; set; }
        public decimal CalculateSalary();

    }

    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal AnnualSalary { get; set; }
        public List<string> Benefits { get; set; }
        public decimal CalculateSalary()
        {
            return AnnualSalary / 12;
        }
    }
}