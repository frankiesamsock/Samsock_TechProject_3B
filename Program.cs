/*
 Author: Frank Samsock
 Date: 9/25/2020
 Description: I have created a C# console application that 
 demonstrates an Array that is the size of 25 elements.
*/
using System;

namespace Samsock_TechProject_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informs the user what is going on
            Console.WriteLine("Here is an auto populated array that is the size of 25 elements!");
            Console.WriteLine("");
            Console.WriteLine("Our array starts with 0. This is why even though the size for the " + '\n' +
                "array is 25 elements, the value of the 25th element is 24. ");
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("");

            //Automatically populating the array
            int[] countdown = new int[25];
            int pop_array = 0;
            //Iterate through the array using a for loop
            for(int i = 0; i < 25; i++)
            {
                countdown[i] = pop_array;
                Console.Write("Element value = " + i + '\n');
                
            }// END FOR

            //Informs how to exit the console
            Console.WriteLine("");
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);
            
        } // END MAIN
    }  // END CLASS
} // END NAMESPACE
