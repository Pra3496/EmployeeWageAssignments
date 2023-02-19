using System.Linq.Expressions;

namespace EmployWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int empCheck = 0;

            bool flag = true;

            Random random = new Random();

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("\nWelcome to Employee Wages Prgrams\n");
                Console.WriteLine("Please enter option given below\n");
                Console.WriteLine("1  : Employee Wage UC1");
                Console.WriteLine("2  : Employee Wage UC2");
                Console.WriteLine("3  : Employee Wage UC3");
                Console.WriteLine("4  : Employee Wage UC4");
                Console.WriteLine("5  : Employee Wage UC5");
                Console.WriteLine("6  : Employee Wage UC6");
                Console.WriteLine("7  : Employee Wage UC7");
                Console.WriteLine("8  : Employee Wage UC8");
                Console.WriteLine("9  : Employee Wage UC9");
                Console.WriteLine("10 : Employee Wage UC10\n");
                Console.WriteLine("Press 0 and Enter To Exit");
                Console.WriteLine("\n===========================================\n");
                Console.Write("ENTER YOUR CHOICE : ");
                int option = Convert.ToInt32(Console.ReadLine());
                //Switch case to call different method 
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n-------{ Employee Wage UC-1 }-------\n");
                        empCheck = random.Next(0, 2);
                        EmployeeWageUC1 emp = new EmployeeWageUC1(empCheck);
                        emp.computeEmpWage();
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n-------{ Employee Wage UC-2 }-------\n");
                        empCheck = random.Next(0, 2);
                        EmployeeWageUC2 empuc2 = new EmployeeWageUC2(empCheck);
                        empuc2.computeEmpWage();
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n-------{ Employee Wage UC-3 }-------\n");
                        empCheck = random.Next(0, 3);
                        EmployeeWageUC3 empuc3 = new EmployeeWageUC3(empCheck);
                        empuc3.computeEmpWage();
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n-------{ Employee Wage UC-4 }-------\n");
                        empCheck = random.Next(0, 3);
                        EmployeeWageUC4 empuc4 = new EmployeeWageUC4(empCheck);
                        empuc4.computeEmpWage();
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\n-------{ Employee Wage UC-5 }-------\n");
                        empCheck = random.Next(0, 3);
                        EmployeeWageUC5 empuc5 = new EmployeeWageUC5(empCheck);
                        empuc5.computeEmpWage();
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("\n-------{ Employee Wage UC-6 }-------\n");
                        empCheck = random.Next(0, 3);
                        EmployeeWageUC6 empuc6 = new EmployeeWageUC6(empCheck);
                        empuc6.computeEmpWage();
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("\n-------{ Employee Wage UC-7 }-------\n");
                        empCheck = random.Next(0, 3);
                        EmployeeWageUC7 empuc7 = new EmployeeWageUC7(empCheck);
                        empuc7.computeEmpWage();
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine("\n-------{ Employee Wage UC-8 }-------\n");
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
                        int total = empuc8.computeEmpWage(company, empRatePerHrs, numOfWorkingdays, maxHrsPerMonth, empCheck);
                        Console.WriteLine("Total Employee wages:" + total);
                        
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine("\n-------{ Employee Wage UC-9 }-------\n");

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
                        
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.WriteLine("\n-------{ Employee Wage UC-10 }-------\n");

                        Console.Write("\nEnter Company Name : ");
                        company = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter Rate per Hours : ");
                        empRatePerHrs = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Number of Working Days : ");
                        numOfWorkingdays = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Maximum Hour per Month : ");
                        maxHrsPerMonth = Convert.ToInt32(Console.ReadLine());

                        EmployeeWageBuilder empuc10 = new EmployeeWageBuilder();
                        empuc10.AddCompanyEmpwage(company, empRatePerHrs, numOfWorkingdays, maxHrsPerMonth);
                        empuc10.ComputeEmpWage();
                        
                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;
                    case 11:
                        Console.WriteLine("\n-------{ Employee Wage UC-11 }-------\n");

                        Console.Write("\nEnter Company Name : ");
                        company = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter Rate per Hours : ");
                        empRatePerHrs = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Number of Working Days : ");
                        numOfWorkingdays = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Maximum Hour per Month : ");
                        maxHrsPerMonth = Convert.ToInt32(Console.ReadLine());

                        EmployeeWageUC11 empuc11 = new EmployeeWageUC11();
                        empuc11.addCompanyEmpWage(company, empRatePerHrs, numOfWorkingdays, maxHrsPerMonth);
                        empuc11.computeEmpWage();

                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;

                    case 12:
                        Console.WriteLine("\n-------{ Employee Wage UC-12 }-------\n");

                        Console.Write("\nEnter Company Name : ");
                        company = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter Rate per Hours : ");
                        empRatePerHrs = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Number of Working Days : ");
                        numOfWorkingdays = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Maximum Hour per Month : ");
                        maxHrsPerMonth = Convert.ToInt32(Console.ReadLine());

                        EmployeeWageUC12 empuc12 = new EmployeeWageUC12();
                        empuc12.addCompanyEmpWage(company, empRatePerHrs, numOfWorkingdays, maxHrsPerMonth);
                        empuc12.computeEmpWage();

                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;

                    case 13:
                        Console.WriteLine("\n-------{ Employee Wage UC-13 }-------\n");

                        Console.Write("\nEnter Company Name : ");
                        company = Convert.ToString(Console.ReadLine());
                        Console.Write("\nEnter Rate per Hours : ");
                        empRatePerHrs = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Number of Working Days : ");
                        numOfWorkingdays = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter Maximum Hour per Month : ");
                        maxHrsPerMonth = Convert.ToInt32(Console.ReadLine());

                        EmployeeWageUC13 empuc13 = new EmployeeWageUC13();
                        empuc13.addCompanyEmpWage(company, empRatePerHrs, numOfWorkingdays, maxHrsPerMonth);
                        empuc13.computeEmpWage();

                        Console.Write("\n\nPress any Key....");
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("\n\nThank You For Using this Application");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }

            }

            
        }
    }
}