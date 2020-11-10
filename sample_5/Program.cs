using System;

namespace sample_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Find area of a circle");
            Console.WriteLine("---------------------\n\n");
            double pi=3.14,s,r;
            
            Console.WriteLine("Yarı çapı giriniz.");
            r = Convert.ToInt32(Console.ReadLine());
            s = pi * (r*r);
            Console.WriteLine("dairenin alanı : "+s);
            Console.ReadKey();

        }
    }
}
