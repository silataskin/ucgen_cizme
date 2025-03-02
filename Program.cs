using System;

namespace UcgenCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            int derinlik = 0; 
            Console.WriteLine("Üçgen çizmek için derinlik sayısı giriniz:");
            derinlik = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= derinlik; i++)
            {
                Console.WriteLine(new string(' ',derinlik - i)+ new string('*',2*i-1));
            }

        }
    }
}