namespace EmployWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            
            

            empCheck = random.Next(0, 2);
            EmployWageUC2 emp = new EmployWageUC2(empCheck);

            emp.Attendences();
        }
    }
}