using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class RefactorCode
    {
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hours_In_Month = 100;
        public void MonthsHours()
        {
            int Emphours = 0;
            int TotalEmpwage = 0;
            int TotalEmphours = 0;
            int Totalworkingdays = 1;

            while (TotalEmphours <= Max_Hours_In_Month && Totalworkingdays <= Num_Of_Working_Days)
            {
                if (TotalEmphours == 100)
                {
                    break;
                }
                Random random = new Random();
                int empcheck = random.Next(3);

                switch (empcheck)
                {
                    case 0:
                        Emphours = 8;
                        break;

                    case 1:
                        Emphours = 4;
                        break;

                    default:
                        Emphours = 0;
                        break;
                }
                TotalEmphours += Emphours;
                Console.WriteLine("Day # " + Totalworkingdays + " Emp hours " + Emphours);
                Totalworkingdays++;
            }
            Console.WriteLine();
            Console.WriteLine("Total employee hours : " + TotalEmphours);
            TotalEmpwage = TotalEmphours * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Employee wage : " + TotalEmpwage);
        }
    }
}
