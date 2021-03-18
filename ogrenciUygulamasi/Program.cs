using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            ogrencinin ogrencinin = new ogrencinin(11,"eyyup","albayrak",60,80,60,"istanbul üniversitesi");
            
            


            while (kontrol)
            {
                islemleriGöster();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        ogrencinin.ogrencininbilgileri();
                        break;

                    case "2":
                     double ogrencininnotortalaması=   ogrencinin.ogrencinortalaması();
                        Console.WriteLine("Öğrencinin not ortalaması :"+ogrencininnotortalaması);
                        break;
                    case "3":
                        ogrencinin.okuladii();
                        break;
                    case "4":
                        kontrol=false;
                        break;

                }
            }
            
            
            

        }


        static void islemleriGöster()
        {
            Console.WriteLine("1- Öğrenci bilgilerini göster :");
            Console.WriteLine("2- Öğrenci ortalamasını göster :");
            Console.WriteLine("3- Öğrencinin okulu :");
            Console.WriteLine("4- Çıkış yap");
        }
        
    }
}
