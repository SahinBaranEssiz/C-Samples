using System;

namespace sample_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Find area of a triangle");
            Console.WriteLine("-----------------------");
            int T, H , S;
            Console.Write("Taban uzunluğunu giriniz: ");
            T = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nYüksekliği giriniz: ");
            H = Convert.ToInt32(Console.ReadLine());

            S = T * H ;
            Console.WriteLine("\nÜçgenin alanı : "+S);

        }
    }
}
