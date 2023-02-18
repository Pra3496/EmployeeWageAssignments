﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class EmployeeWageUC6
    {
        int empCheck;
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;
        public const int EMP_RATE_PER_HRS = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_RATE_IN_MONTH = 100;

        public EmployeeWageUC6(int empCheck)
        {
            this.empCheck = empCheck;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < MAX_RATE_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
            int totalEmpWages = totalEmpHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Total Employee wages:" + totalEmpWages);
        }
    }
}
