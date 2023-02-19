using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class EmployeeWageUC2
    {
        int empCheck;

        public EmployeeWageUC2(int empChk)
        {
            this.empCheck = empChk;
        }
        public void computeEmpWage()
        {
            int IS_PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWages = 0;

            if (this.empCheck == IS_PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWages = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wages: " + empWages);
        }
    }
}
