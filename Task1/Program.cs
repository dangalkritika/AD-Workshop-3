
namespace Task1
{
    internal class Operators
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine("Difference: " + (a - b));
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Product: " + (a * b));
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine("Division: " + (a / b));
        }

        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine($"{number} is an {result}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Operators op = new Operators();

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            op.Add(a, b);
            op.Subtract(a, b);
            op.Multiply(a, b);
            op.Divide(a, b);

            Console.Write("\nEnter a number to check Odd or Even: ");
            int num = Convert.ToInt32(Console.ReadLine());
            op.OddEvenFinder(num);
        }
    }
}
