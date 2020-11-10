using System;

namespace sample_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Factorial of a number ");
            Console.WriteLine("---------------------");
            ulong f;
            ulong s=1;
            Console.WriteLine("Faktoriyelini hesaplamak istediğiniz sayıyı giriniz:");
            f = Convert.ToUInt32(Console.ReadLine());
            for (uint i = 1; i <= f; i++)
            {
                
                s = s * i;
                Console.WriteLine("" + s );
            }
            Console.WriteLine("sonuc: " + s );
        }
    }
}
