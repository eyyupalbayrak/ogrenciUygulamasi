using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciUygulamasi
{
    public class ogrencinin
    {
        private int ogrencino;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;
        

        public ogrencinin(int _ogrencino, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulismi)
        {
            ogrencino = _ogrencino;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
            
            
        }
     

        public void ogrencininbilgileri()
        {
            Console.WriteLine("Öğrencini adı :"+isim);
            Console.WriteLine("öğrencinin soyadı :"+soyisim);
            Console.WriteLine("öğrencinin numarası :"+ogrencino);
            Console.WriteLine("öğrencinin okul ismi :"+okulismi);
            Console.WriteLine("öğrencinin vize 1 ortalaması :"+vize1);
            Console.WriteLine("öğrencinin vize 2 ortalaması :"+vize2);
            Console.WriteLine("öğrencinin final ortalaması :"+final);
        }

        public double ogrencinortalaması()
        {
            double notortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return notortalama;
        }
        
        public void okuladii()
        {
            Console.WriteLine("öğrencinin okul adı :"+okulismi);
        }
        
        
    }
}
