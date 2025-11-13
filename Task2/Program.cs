using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
          
            string username = null;

            string ternaryResult = (username == null) ? "Username is not available" : username;
            Console.WriteLine("Ternary Operator Result: " + ternaryResult);

            // Check using null-coalescing operator
            string coalescingResult = username ?? "Username is not available";
            Console.WriteLine("Null-Coalescing Operator Result: " + coalescingResult);

            // Assign value using null-coalescing assignment
            username ??= "DefaultUser";
            Console.WriteLine("After Null-Coalescing Assignment, username = " + username);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object and call method
            NullOperations nullOps = new NullOperations();
            nullOps.PerformNullChecks();
        }
    }
}
