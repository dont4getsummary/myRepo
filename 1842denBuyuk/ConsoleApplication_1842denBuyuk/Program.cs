using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_1842denBuyuk
{
    class Program
    {
        static void Main(string[] args)
        {
            //int giris = (DateTime.Now.Millisecond);
            DateTime start = DateTime.Now;
            int x = 1842;
            int[] dizi;            
            Asal250(x);
            dizi = Asal250(x);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            //int cıkıs = (DateTime.Now.Millisecond); 
            //zaman farkı işlemini araştır.
            DateTime end = DateTime.Now;
            TimeSpan sure = end - start;
            //int sure = cıkıs - giris;
            Console.Write(sure.Milliseconds);  // ref parameter ile de yapılabilirdi..
            Console.ReadLine();
        }
        static int[] Asal250 (int sayi)
        {
            int Saysin = 250;
            int[] asalDizi = new int[Saysin];
            int diziSay = 0;
            for (int i = 0 ;; i++)
            {
                sayi = sayi + 1;
                bool asal = true;
                for (int j = 2; j <= sayi / 2; j++)
                {
                    if (sayi % j == 0)
                    {
                        asal = false;
                        break;
                    }
                }
                if (asal == true) {
                    asalDizi[diziSay] = sayi;
                    diziSay++;
                }
                if (diziSay == Saysin)
                {
                    break;
                }
            }
            return asalDizi;
        }
    }
}
