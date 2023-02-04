namespace EmployWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            Console.WriteLine("\nEmployeeWage UC - 2");

            empCheck = random.Next(0, 2);
            EmployWageUC2 emp = new EmployWageUC2(empCheck);

            emp.Attendences();

            Console.WriteLine("\nEmployeeWage UC - 3");
            
            empCheck = random.Next(0, 3);
            EmployeeWageUC3 empuc3 = new EmployeeWageUC3(empCheck);
            empuc3.Attendences();

            Console.WriteLine("\nEmployeeWage UC - 4");

            empCheck = random.Next(0, 3);
            EmployeeWageUC4 empuc4 = new EmployeeWageUC4();
            empuc4.Attendances(empCheck);

            Console.WriteLine("\nEmployeeWage UC - 5");


            empCheck = random.Next(0, 3);
            EmployeeWageUC5 empuc5 = new EmployeeWageUC5();
            empuc5.Attendences(empCheck);






        }
    }
}