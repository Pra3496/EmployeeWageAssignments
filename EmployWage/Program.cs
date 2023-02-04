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





        }
    }
}