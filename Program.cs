using System;

namespace Samsock_TechProject_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here is an auto populated array that is the size of 25 elements!");
            Console.WriteLine("");
            Console.WriteLine("Our array starts with 0. This is why even though the size for the " + '\n' +
                "array is 25 elements, the value of the 25th element is 24. ");
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("");

            int[] countdown = new int[25];
            int pop_array = 0;
            for(int i = 0; i < 25; i++)
            {
                countdown[i] = pop_array;
                Console.Write("Element value = " + i + '\n');
                
            }
            Console.WriteLine("");
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);
            
        }
    }
}
