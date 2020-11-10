using System;

namespace sample_4
{
    class Program
    {
        static void Main(string[] args)
       {
            Console.WriteLine("Floyd Triangle!!");
            int j, val = 1,n=16; 
        for (int i = 1; i <= n; i++) 
         { 
            for (j = 1; j <= i; j++) 
            { 
                Console.Write(val + " "); 
                val++; 
            } 
            Console.WriteLine(); 
         }
       }
    }
}
