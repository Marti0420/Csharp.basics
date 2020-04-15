using System;
using System.Collections.Generic;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] {1, 2, 3, 4};

            Console.WriteLine(array[2]);

            var list = new List<int>(){1,2,3,4,5,6}; 
            Console.WriteLine(list.Count);

            list.Add(7);
            list.Add(8);
            
            Console.WriteLine(list.Count);

            list.Remove(5);
            
            
            // LOOPS
            
            // FOR

            for (;;)
            {
                Console.WriteLine("INFINITE");
            }

            // WHILE
            

            // DO WHILE

            // FOREACH 

            foreach (var number in list)

            {
                
            }
        }
    }
}