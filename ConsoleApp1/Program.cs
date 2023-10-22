using ConsoleApp1.Exceptions;
using ConsoleApp1.Helper;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int button;
            Department department = new Department("Remzi MMC",5);
            

            do
            {
                Console.WriteLine("1.Employye elave et "+"\n2.Isci axtar "+"\n3.Butun iscilere bax "+"\n4.Maas araligina gore Iscileri axtaris et"+" \n5.Departmente gore iscileri axtar "+"\n6.Positiona gore iscileri daxil et "+"\n7.Iscini qov"+" \n0.Proqrami bitir");
                Console.WriteLine("derhal sec birin");
                button=int.Parse(Console.ReadLine());
                switch (button)
                {
                    case 1:
                        department.AddEmployee(CreateEmployee());
                        break;
                    case 2:
                        Console.WriteLine("id daxil edin: ");
                        int id = int.Parse(Console.ReadLine());
                        Employee employee = department.GetEmployee(id);
                        Console.WriteLine(employee);
                        break;
                    case 3:
                        department.ShowAllEmployees();

                        break;
                    case 4:
                        Console.WriteLine("minimum salary daxil et");
                        int a=int.Parse(Console.ReadLine());
                        Console.WriteLine("maxcimum salary daxil et");
                        int b=int.Parse(Console.ReadLine());                        
                        foreach (var item in department.GetEmployeeBySalary(a, b))
                        {
                            Console.WriteLine(item.GetInfo());
                        }
                        break;
                    case 5:
                        case 6:
                        Console.WriteLine("position sec");
                        Console.WriteLine("1-Boss"+"\n2-Engineer"+"\n3-HR");
                        int button3 = int.Parse(Console.ReadLine());
                        Position pos;
                        switch (button3)
                        {
                            case 1:  pos = Position.Boss;
                                break;
                            case 2:  pos = Position.Engineer;
                                break;
                            case 3:  pos = Position.HR;
                                break;
                            default: pos = 0;  
                                continue;
                        }
                        foreach (var item in department.GetEmployeesByPosition(pos))
                        {
                            Console.WriteLine(item.GetInfo());
                        }
                        break;
                    case 7:
                        Console.WriteLine("id deyerin qeyd edin");
                        int idd = int.Parse(Console.ReadLine());
                        department.RemoveEmployee(idd);
                        break;

                    default:
                        break;

                }
            } while (button!=0);


       
        
        
        }


         public static Employee CreateEmployee()
        {
            Console.WriteLine("iscinin adin girin ");
           string name= Console.ReadLine();
           Console.WriteLine("iscinin yasini girin");
            sbyte age = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("iscinin maasini girin");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("iscinin posizyonunu secin");
            Console.WriteLine("1-Boss"+"\n2-Engineer"+"\n3-HR");
            int button2 =int.Parse(Console.ReadLine());
            Position position;
            switch (button2)
            {
                case 1:
                     position = Position.Boss;
                    break;
                    case 2:
                     position = Position.Engineer;
                    break;
                case 3:
                     position = Position.HR;
                    break;

                default:
                    position =0;
                    break;
            }
            Employee employee = new Employee(name, age, salary,position);
            return employee;

            
        }
    }
}