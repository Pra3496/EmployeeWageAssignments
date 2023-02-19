using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    public interface IcomputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth);

        public void computeEmpWage();

        public int getTotalWage(String company);
    }
}
