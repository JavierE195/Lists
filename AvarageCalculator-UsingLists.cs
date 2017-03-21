using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Insert the number of elements in the list: ");
            int numberElements = int.Parse(Console.ReadLine());
            double y = 0;

            for (int i = 0; i < numberElements; i++)
            {
                Console.Write("Insert element number " + (i + 1) + " : ");
                double individualElement = double.Parse(Console.ReadLine());
                y = individualElement + y;

            }

            double total = y / numberElements;

            Console.WriteLine("The avarage of the numbers is: " + total);
            Console.ReadKey();
        }
    }
}
