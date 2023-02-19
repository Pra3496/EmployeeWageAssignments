using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class EmployeeWageUC1
    {
        int empCheck;

        public EmployeeWageUC1(int empChk)
        {
            this.empCheck = empChk;
        }

        public void computeEmpWage()
        {
            int IS_PRESENT = 1;
            if (this.empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }


    }
}
