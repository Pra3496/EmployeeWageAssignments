using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class EmployWageUC1
    {
        int empCheck;

        public EmployWageUC1(int empChk)
        {
            this.empCheck = empChk;
        }

        public void Attendencs()
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
