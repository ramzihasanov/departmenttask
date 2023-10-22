using ConsoleApp1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Employee:IPerson
    {
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public sbyte Age { get; set; }
        public double Salary { get; set; }
        public Position EmployePosition { get; set; }

        static Employee()
        {
            _id = 0;
                   
        }

        public Employee(string name,sbyte age, double salary,Position position)
        {
            _id++;
            Id=_id;
            Name = name;
            Age = age;
            Salary = salary;
            EmployePosition = position;
        }
        public string GetInfo()
        {
            return $"ID: {Id}  Name: {Name} Age: {Age}  Salary: {Salary} Position: {EmployePosition}";
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID {Id}"+$"\n name {Name}"+$"\n salary {Salary}"+$"\nposition {EmployePosition}");
           
        }

        public override string ToString()
        {
            return GetInfo();
        }




    }
}
