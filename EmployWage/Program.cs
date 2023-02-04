namespace EmployWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = 0;

            

            Console.WriteLine("\nEmployeeWage UC - 6");


            empCheck = random.Next(0, 3);
            EmployeeWageUC5 empuc5 = new EmployeeWageUC5();
            empuc5.Attendences(empCheck);






        }
    }
}