using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpım_tablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, sonuc;
            string islem;
            Console.WriteLine("1.sayıyı giriniz");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("2. sayıyı giriniz");
            sayı2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("işlem seçin= +,-,*,/");
            
            islem = Console.ReadLine();
            Console.WriteLine("");
            if (islem == "+")
            {
                sonuc = sayı1 + sayı2;
                Console.WriteLine("sonuc= "+sonuc);
            }
            if (islem  == "-")
            {
                sonuc = sayı1 - sayı2;
                Console.WriteLine("sonuc= " + sonuc);
            }
            if (islem == "*")
            {
                sonuc = sayı1 * sayı2;
                Console.WriteLine("sonuc= " + sonuc);
            }
            if (islem == "/")
            {
                sonuc = sayı1 / sayı2;
                Console.WriteLine("sonuc= " + sonuc);
            }
            Console.ReadLine();
        }
    }
}
