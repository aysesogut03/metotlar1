using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int kareDeger = kareAl(sayi);
            if (kareDeger > 25)
            {
                Console.WriteLine("Sayının karesi 25 den büyüktür.");
            }
            else
            {
                Console.WriteLine("Sayının karesi 25 den küçüktür.");
            }

            Console.ReadLine();
        }
        


        static int kareAl(int a)
        {
            return a * a;
        }
        
    }
}
