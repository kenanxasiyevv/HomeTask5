using System.Diagnostics.CodeAnalysis;

namespace HomeTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil et: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int r = 1; r < number; r++)
            {
                if (number > r * r)
                    sum++;

            }
            Console.WriteLine(sum);
        }
    }
}