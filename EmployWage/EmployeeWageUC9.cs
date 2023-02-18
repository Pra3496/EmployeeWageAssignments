using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class EmployeeWageUC9
    {
        //Initialize input
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        private string company;
        private int empRatePerHrs;
        private int numOfWorkingdays;
        private int maxHrsPerMonth;
        private int totalEmpWage;

        private int empCheck;

        public EmployeeWageUC9(string company, int empRatePerHrs, int numOfWorkingdays, int maxHrsPerMonth, int empCheck) 
        { 
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.numOfWorkingdays= numOfWorkingdays;
            this.maxHrsPerMonth= maxHrsPerMonth;
            this.empCheck= empCheck;
        }

        public void computeEmpWage()
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

            totalEmpWages = totalEmpHrs * this.empRatePerHrs;
            Console.WriteLine("Total Emp Wage for Company : "+company+" is "+totalEmpWage);
        }

        public string toString()
        {
            return "This Emp Wage for Company : " + this.company + " is :" + this.totalEmpWage;
        }
    }
}
