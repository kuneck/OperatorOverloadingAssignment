using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Rambo"
            };

            // Create the second Employee object
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "John",
                LastName = "Wick"
            };

            // Create the third Employee object with the same Id as the first one
            Employee employee3 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Rambo"
            };

            // Check if employee1 is equal to employee2
            Console.WriteLine("Are employee1 and employee2 equal? " + (employee1 == employee2));

            // Check if employee1 is equal to employee3
            Console.WriteLine("Are employee1 and employee3 equal? " + (employee1 == employee3));

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
