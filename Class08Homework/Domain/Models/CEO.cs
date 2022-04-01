using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CEO : Employee //nova klasa soglasno baranja na domasnoto
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public CEO(string firstName, string lastName, Employee[] employees, int shares, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Employees = employees;
            Shares = shares;
            Salary = salary;
            Role = RoleEnum.Other;
        }
        public void PrintEmployees()
        {
            int i = 1;
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{i++}. {employee.FirstName} {employee.LastName}");
            }
        }
        public void AddSharesPrice(double sharesPrice)
        {
            _sharesPrice = sharesPrice;
        }
        public override double GetSalary()
        {
            return Salary + Shares * _sharesPrice;
        }

    }
}
