using Domain.Enums;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }
        public string Department { get; set; } // dodadov department property za da ima smisla metodot
        //CurrentPosition() vo klasa Contractor. drugo e se isto kako na cas

        public Manager(string firstName, string lastName, double salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Department = department;
            Role = RoleEnum.Manager;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        //Manager has specific implementation for the GetSalary method
        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
