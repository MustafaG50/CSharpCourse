using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev.DersÖdev
{
    public class ÖdevÜslüSayı
    {
        public ÖdevÜslüSayı()
        {
            while (true)
            {
                decimal sonuç = 1;
                Console.WriteLine("Sayı giriniz(Taban) :");
                int taban = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı giriniz(Üs) :");
                int üs = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= üs; i++)
                {
                    sonuç *= taban;
                }
                sonuç.ToString();
                Console.WriteLine(sonuç);
            }
        }
       
    }
}
