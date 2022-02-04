using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Tanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Methodlar=>Fonksiyonlar
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            int sonuc=Topla(5,9);
            Metotlar ornek= new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));//sonuc integer olduğu için stringe çevirdik çünkü fonksiyon string veri alıyor.
            
           int sonuc2 = ornek.ArttırveTopla(ref a,ref b);//referans vermek a ile b değeri değil bellekteki karşılıklarını veriyorum demektir.
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }
       static int Topla(int deger1,int deger2)// static main e sadece static methodlar erişilebilir.
        {
            return deger1 + deger2;
        }
    }
    class Metotlar
    {
          public void EkranaYazdir(string veri) //erişebilir olması için public
        {
            Console.WriteLine("Toplamlarının sonucu {0} sayısıdır.",veri);
        }
        public int ArttırveTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
