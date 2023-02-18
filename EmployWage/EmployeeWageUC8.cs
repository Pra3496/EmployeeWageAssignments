using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class EmployeeWageUC8
    {
        //Initialize input
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        //Created method Employee wage UC6 & UC7
        public int computeEmpWage(string company, int empRatePerHrs, int numOfWorkingdays, int maxHrsPerMonth,int empCheck)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < maxHrsPerMonth && totalWorkingDays < numOfWorkingdays)
            {
                totalWorkingDays++;
                switch (empCheck)
                {
                    case IS_PARTTIME: 
                        empHrs = 4;
                        break;
                    case IS_FULLTIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWages = totalEmpHrs * empRatePerHrs;
            
            return totalEmpWages;
        }
    }
}
