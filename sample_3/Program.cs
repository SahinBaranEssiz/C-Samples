using System;

namespace sample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci dizisi!!!!!!");
            int a=0;
            int b=0;
            int dongu;

            Console.Write("kaç tur dönsün: ");
            dongu = Convert.ToInt32(Console.ReadLine());
            Console.Write("sayı kaçtan başlasın: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < dongu; i++)
            {
                if (i % 2 == 0){
                 a = a + b;
                Console.Write(a + "/");}
                else {
                     b = a + b;
                Console.Write(b + "/");
                }
                
            }


        }
    }
}
