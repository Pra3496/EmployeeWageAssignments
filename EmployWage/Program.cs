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
            RefactorCode empuc7 = new RefactorCode();

            empuc7.MonthsHours();






        }
    }
}