

namespace EmployeeData
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double idNumber = double.Parse(Console.ReadLine());
            long employeeumber = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {idNumber}");
            Console.WriteLine($"Unique Employee number: {employeeumber}");
        }
    }
}
