using System;
using Domain.Enums;
using Domain.Models;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee()
            //{
            //    FirstName = "Marko",
            //    LastName = "Markovski",
            //    Role = RoleEnum.Other
            //};
            //employee.PrintInfo();

            //SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            //salesPerson.AddSuccessRevenue(300);
            //GetSalary from SalesPerson is called
            //Console.WriteLine(salesPerson.GetSalary());

            //Manager manager = new Manager("Bill", "Billsky", 700, "Marketing");
            //GetSalary from Manager is called
            //Console.WriteLine(manager.GetSalary());
            //manager.AddBonus(200);
            //manager.AddBonus(100);
            //GetSalary from Manager is called
            //Console.WriteLine(manager.GetSalary());
            
            
            
            //domasnoto pocnuva od tuka. Soglasno baranjata dodadov dve novi klasi na vraboteni - Contractor i CEO.
            //Dopolnitelno na toa, vo klasata Manager dodadov property za department za da moze
            //i da ima smisla da se kreira metodot CurrentPosition vo klasa Contractor. Ostanatite klasi gi ostaviv
            //kako sto si gi rabotevme na cas.

            Manager manager = new Manager("Bob", "Bobert", 700, "Marketing");//prv menadzer
            Manager secondManager = new Manager("Rick", "Rickert", 800, "Accounting");//vtor menadzer
            Contractor contractor = new Contractor("Mona", "Monalisa", 40, 5, manager);//prv izveduvac
            //Console.WriteLine(contractor.GetSalary());
            //Console.WriteLine(contractor.CurrentPosition());
            Contractor contractorSecond = new Contractor("Igor", "Igorsky", 30, 7, secondManager);//vtor izveduvac
            //Console.WriteLine(contractorSecond.GetSalary());
            //Console.WriteLine(contractorSecond.CurrentPosition());
            SalesPerson salesPerson = new SalesPerson("Lea", "Leova");//eden za prodazba
            //Console.WriteLine(salesPerson.FirstName);
            Employee [] employeesInCompany = new Employee[] 
            { manager, secondManager, salesPerson, contractor, contractorSecond };//array od 5 objekti za sekoj vraboten
            //employeesInCompany[0].PrintInfo();
            CEO someCEO = new CEO("Ron", "Ronsky", employeesInCompany, 100, 1500);//instanciranje na CEO
            //someCEO.PrintInfo();
            //someCEO.PrintEmployees();
            //Console.WriteLine(someCEO.GetSalary());
            //someCEO.AddSharesPrice(545);
            //Console.WriteLine(someCEO.GetSalary());

            //ocekuvaniot autput soglasno baranjata na domasnoto
            Console.WriteLine($"Expected output: \nCEO: \nFirst Name: {someCEO.FirstName}, Last Name: {someCEO.LastName}, Salary: {someCEO.GetSalary()}$");
            someCEO.AddSharesPrice(14);
            Console.WriteLine($"Total salary of CEO is: {someCEO.GetSalary()}$");
            Console.WriteLine("Employees:");
            someCEO.PrintEmployees();
        }
    }
}
