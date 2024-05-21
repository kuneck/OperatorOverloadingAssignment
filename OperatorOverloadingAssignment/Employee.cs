using System;

namespace OperatorOverloadingAssignment
{
    // Define the Employee class
    public class Employee
    {
        // Property for Employee ID
        public int Id { get; set; }

        // Property for Employee First Name
        public string FirstName { get; set; }

        // Property for Employee Last Name
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects based on their Id property
        public static bool operator ==(Employee id1, Employee id2)
        {
            // Check if both objects are null
            if (ReferenceEquals(id1, null) && ReferenceEquals(id2, null))
            {
                return true;
            }

            // Check if one object is null
            if (ReferenceEquals(id1, null) || ReferenceEquals(id2, null))
            {
                return false;
            }

            // Compare the Id properties of both Employee objects
            return id1.Id == id2.Id;
        }

        // Overload the '!=' operator as well, which must be done in pairs with '=='
        public static bool operator !=(Employee id1, Employee id2)
        {
            return !(id1 == id2);
        }

        // Override Equals method to ensure correct behavior when used with collections
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee
            if (obj is Employee employee)
            {
                // Compare the Id properties
                return this.Id == employee.Id;
            }

            return false;
        }

        // Override GetHashCode method to ensure consistency with Equals
        public override int GetHashCode()
        {
            // Use the Id property to generate a hash code
            return this.Id.GetHashCode();
        }
    }
}
