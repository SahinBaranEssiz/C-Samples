using System;

namespace sample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Karakterinizin wisdom puanını giriniz: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Random rd = new Random();
            int rand_num = rd.Next(1,20);
            Console.WriteLine(rand_num+"\n");
            if (a > 1 && a<6)
            Console.WriteLine(rand_num - 1);
            else if (a > 6 && a<10)
            Console.WriteLine(rand_num +1);
            else if (a > 10 && a<16)
            Console.WriteLine(rand_num +2);
            else
            Console.WriteLine(rand_num +4);
            Console.ReadKey();
        }
    }
}
