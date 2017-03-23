using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); 
            Console.WriteLine("Insert the amount of elements in the list: ");
            int Length = int.Parse(Console.ReadLine());

            for (int i = 0; i < Length; i++)
            {
                Console.Write("Insert the element number " + (i + 1) + " : " );
                int element = int.Parse(Console.ReadLine());
                numbers.Add(element);
            }

            Console.WriteLine("\nThe list is the following: ");
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string answer;
            int position = 0;

            Console.WriteLine("\nWould you like to remove an element from the already existing list? ");
            answer = Console.ReadLine();
            if (answer != "Yes" || answer != "yes" || answer != "YES")
            {
                Console.WriteLine("\nInsert the position of the element you want to remove: ");
                position = (int.Parse(Console.ReadLine()) - 1);
            }

           
            Console.WriteLine("\nThe final list is: ");
            for (int i = 0; i < Length; i++)
            {
                if (i != position)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.ReadKey();
        }

    }
}
