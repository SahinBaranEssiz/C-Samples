using System;

namespace sample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=0;
            float c;
            int d=1;
            Console.WriteLine("Bir sayı giriniz : ");
                a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı giriniz : ");
                b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yapmak istediğinit işlemin numarasını giriniz: \n 1)Toplama \n 2)Çıkarma \n 3)Bölme \n 4)Çarpma \n 5)iki sayının karesinin yoplamı");
            d = Convert.ToInt32(Console.ReadLine());
                if (d == 1)
                {c = a + b;}
                else if (d == 2)
                {c = a - b;}
                else if (d == 3)
                {c = a / b;}
                else if (d == 4)
                {c = a * b;}
                else 
                {c= (a*a)+(b*b);  }
                
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
