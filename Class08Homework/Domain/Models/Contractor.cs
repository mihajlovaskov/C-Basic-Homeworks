using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Contractor : Employee//nova klasa soglasno baranjata na domasnoto
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workhours, int payperhour, Manager responsible)
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workhours;
            PayPerHour = payperhour;
            Salary = GetSalary();//specific for Contractor
            Responsible = responsible;
            Role = RoleEnum.Other;
        }

        public string CurrentPosition() 
        {
            string pos = Responsible.Department;
            return pos;
        }

        public override double GetSalary()
        {
            return WorkHours * PayPerHour;
        }
    }
}
