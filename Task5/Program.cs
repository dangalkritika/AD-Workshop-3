namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum from 1 to " + N + " is: " + sum);

            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");

            int num = 1;
            while (num <= 20)
            {
                if (num == 15)
                    break; 

                if (num % 4 == 0)
                {
                    num++;   
                    continue;
                }

                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("\nSum of all elements in an array:");

            int[] numbers = { 5, 10, 15, 20, 25 };
            int total = 0;

            foreach (int x in numbers)
            {
                total = total + x;
            }

            Console.WriteLine("Sum of array elements: " + total);
        }
    }
}


