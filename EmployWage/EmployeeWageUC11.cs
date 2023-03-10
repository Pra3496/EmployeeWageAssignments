using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployWage
{
    internal class EmployeeWageUC11 : IcomputeEmpWage
    {
        public const int IS_PARTTIME = 1;
        public const int IS_FULLTIME = 2;

        private  LinkedList<CompanyEmpWage>CompanyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> CompanyToEmpWagMap;


        public EmployeeWageUC11()
        {
            this.CompanyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.CompanyToEmpWagMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string company, int empRatePerHr, int numOfWorkingDays, int maxHrsPerMonth)
        {
           CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxHrsPerMonth);
           this.CompanyEmpWagesList.AddLast(companyEmpWage);
            this.CompanyToEmpWagMap.Add(company, companyEmpWage);   
        }
        public void computeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.CompanyEmpWagesList)
            {
                companyEmpWage.SetTotalEmpWages(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs < companyEmpWage.maxHrsPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
            return totalEmpHrs * companyEmpWage.empRatePerHr;
        }

        public int getTotalWage(String company)
        {
            return this.CompanyToEmpWagMap[company].totalEmpWages;
        }
    }
}
