using ConsoleApp1.Exceptions;
using ConsoleApp1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Department
    {
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }



        Employee[] Employees;

        public void AddEmployee(Employee employee)
        {
            if (EmployeeLimit > Employees.Length)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                Employees[Employees.Length - 1] = employee;
            }
            else throw new CapacityLimitException("limit asilmisdir");
        }

        public void AddEmployee( ref Employee[] emp, Employee employee)
        {
            
                Array.Resize(ref emp, emp.Length + 1);
                emp[emp.Length - 1] = employee;
          
        }



        public void RemoveEmployee(int id)
        {
            Employee[] NewEmployees=new Employee[Employees.Length-1];
            for (int i = 0; i < Employees.Length; i++)
            {
                if (id != Employees[i].Id) 
                    NewEmployees[i] = Employees[i]; 

            }
            Employees = NewEmployees;
        }


        public Employee GetEmployee(int id)
        {
            foreach (var item in Employees)
            {
                if(id==item.Id)
                    return item;
            }
            return null;
        }


        public Employee[] GetEmployeeBySalary(double minSalary,double maxSalary)
        {
            Employee[] NewEmployees = new Employee[0];
            for (int i = 0; i < Employees.Length; i++)
            {
                if(minSalary < Employees[i].Salary && maxSalary > Employees[i].Salary)
                {
                    AddEmployee(ref NewEmployees, Employees[i]);

                }           
            }
            return NewEmployees;
        }


        //public Employee[] GetEmployeesByDeparmentName(string departmentName)
        //{
        //    Employee[] NewEmployees = new Employee[0];
        //    for (int i = 0; i < Employees.Length; i++)
        //    {
        //        if (departmentName == Employees[i].)
        //        {
        //            AddEmployee(NewEmployees, Employees[i]);

        //        }
        //    }
        //    return NewEmployees;
        //}


        public Employee[] GetEmployeesByPosition(Position position)
        {
            Employee[] NewEmployees = new Employee[0];
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].EmployePosition ==position)
                {
                    AddEmployee(ref NewEmployees, Employees[i]);

                }
            }
            return NewEmployees;

        }

        public Employee this[int index]
        {
            get => Employees[index];

            set
            {
                if (index >= 0 && index < Employees.Length)
                {
                    Employees[index] = value;
                }
             
            }
        }
        public void ShowAllEmployees() {

            foreach (var item in Employees)
            {
                Console.WriteLine(item.GetInfo());

            }

        }





    static Department()
        {
            _id = 0;


        }

        public Department(string name, int employelimit)
        {
            Employees=new Employee[0];
            _id++;
            Id = _id;
            Name = name;
            EmployeeLimit=employelimit;

        }
    }
}
