using System.Linq.Expressions;

namespace EmployWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int empCheck = 0;

            Random random = new Random();

            Console.WriteLine("Welcome to Employee Wages Prgrams");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Employee is present or absent UC1\n2:Employee Wage UC2\n3:Employee wage UC3\n4:Employee wage UC4\n5:Employee wage UC5\n6:Employee wage UC6\n7:Refactor Employee wage UC7\n8:Refactor to compute multiple company wages");
            int option = Convert.ToInt32(Console.ReadLine());
            //Switch case to call different method 
            switch (option)
            {
                case 1:
                    empCheck = random.Next(0, 2);
                    EmployWageUC1 emp = new EmployWageUC1(empCheck);
                    emp.attendencs();
                    break;
                case 2:
                    empCheck = random.Next(0, 2);
                    EmployWageUC2 empuc2 = new EmployWageUC2(empCheck);
                    empuc2.attendences();
                    break;
                case 3:
                    empCheck = random.Next(0, 3);
                    EmployeeWageUC3 empuc3 = new EmployeeWageUC3(empCheck);
                    empuc3.attendences();
                    break;
                case 4:
                    empCheck = random.Next(0, 3);
                    EmployeeWageUC4 empuc4 = new EmployeeWageUC4(empCheck);
                    empuc4.attendances();
                    break;
                case 5:
                    empCheck = random.Next(0, 3);
                    EmployeeWageUC5 empuc5 = new EmployeeWageUC5(empCheck);
                    empuc5.attendences();
                    break;
                case 6:     
                    empCheck = random.Next(0, 3);
                    EmployeeWageUC6 empuc6 = new EmployeeWageUC6(empCheck);
                    empuc6.computeEmpWage();
                    break;
                case 7:
                    empCheck = random.Next(0, 3);
                    EmployeeWageUC7 empuc7 = new EmployeeWageUC7(empCheck);
                    empuc7.computeEmpWage();
                    break;
                case 8:
                    empCheck = random.Next(0, 3);
                    Console.Write("\nEnter Company Name : ");
                    string company = Convert.ToString(Console.ReadLine());
                    Console.Write("\nEnter Rate per Hours : ");
                    int empRatePerHrs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter Number of Working Days : ");
                    int numOfWorkingdays = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter Maximum Hour per Month : ");
                    int maxHrsPerMonth = Convert.ToInt32(Console.ReadLine());
                    EmployeeWageUC8 empuc8 = new EmployeeWageUC8();
                    int total = empuc8.computeEmpWage(company,empRatePerHrs,numOfWorkingdays,maxHrsPerMonth,empCheck);
                    Console.WriteLine("Total Employee wages:" + total);
                    break;
                case 9:
                    empCheck = random.Next(0, 3);
                    Console.Write("\nEnter Company Name : ");
                    company = Convert.ToString(Console.ReadLine());
                    Console.Write("\nEnter Rate per Hours : ");
                    empRatePerHrs = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter Number of Working Days : ");
                    numOfWorkingdays = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nEnter Maximum Hour per Month : ");
                    maxHrsPerMonth = Convert.ToInt32(Console.ReadLine());
                    EmployeeWageUC9 empuc9 = new EmployeeWageUC9(company, empRatePerHrs, numOfWorkingdays, maxHrsPerMonth, empCheck);
                    empuc9.computeEmpWage();
                    Console.WriteLine(empuc9.toString());
                    break;
                case 0:
                    Console.WriteLine("Thank You For Using this Application");
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;

            }
        }
    }
}