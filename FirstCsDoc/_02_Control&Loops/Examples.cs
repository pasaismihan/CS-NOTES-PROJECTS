using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _02_Control_Loops
{
	internal class Examples
	{
		  static void Main(string[] args)
		{

    //ORNEKLER----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // Ekrandan girilen degerin tamsayi tipinde degiskene atanmasi
            Console.WriteLine("lutfen bir sayi giriniz");
                string input = Console.ReadLine();

                int sayi = Convert.ToInt32(input);
                Console.WriteLine("atama yapildi");
                Console.Read();
                Environment.Exit(0); // uygulamayi kapatir
          // ustteki kod blogunu yaptigimizda terminale metin girdimiz zaman hata aliriz bu yuzden her bir harf ve sembolu tek tek tanimlamamiz gerekir bunun yerine alttaki islemi yapariz;
        }
        public static void Islem()
        {
                Console.WriteLine("lutfen bir sayi giriniz");
                string input = Console.ReadLine();
                int sayi;
                bool donustuMu = int.TryParse(input, out sayi);
            if (!donustuMu)
            {
                Console.WriteLine("atama yapilirken bir hata olustu");
                Console.Read();
            }
            else
            {
                Console.WriteLine("atama yapildi");
                Console.Read();
            }
        // bu ornekte int turunun bir ozelligini kullandik tryparse kullanimi convert den farkli olarak metinsel herhangi bir ifade gordugunde bunu int e ceviriyor ve bize boolean donduruyor
        // string.Format icerisinde deger belirtebildigimiz gibi Console.Write("islemin sonucu {0}",islem) seklinde de yapabiliriz  
        }


        // Ekrandan kac sayinin alinacagini oku daha sonra bu sayilari toplayip toplamini ekranda don
        public static void Toplam()
        {
            string input;
            int sayiAdeti = 0;
            bool donustuMu = false;
            while (!donustuMu) {
             Console.Write("Kac adet sayiyi toplamak istersiniz : ");
                input =  Console.ReadLine();
                donustuMu = int.TryParse(input, out sayiAdeti);
                if (!donustuMu)
                {
                    Console.WriteLine("sayi adetini girerken bir hata ile karsilasildi");
                    Thread.Sleep(5000); // kodun bir sonraki satirina gecmeden once beklemesini istiyorsak kullaniyoruz 
                    Console.Clear();
                    continue;
                }
        
            }
            int[] sayilar = new int[sayiAdeti];
            for (int i = 0; i < sayiAdeti; i++)
            {
                Console.Write("lutfen {0} sayiyi giriniz", i + 1);
                input = Console.ReadLine();
                int sayi;
                donustuMu = int.TryParse(input,out sayi);
                if (!donustuMu)
                {
                    Console.WriteLine("{0}.sayiyi girerken bir hata olustu",i+1);
                    Console.Read();
                    Environment.Exit(0);
                }
                sayilar[i] = sayi;   
            }
            long toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += (long)sayilar[i];
            }
            Console.WriteLine("sayilarin toplami{0}"+ toplam+ "dir");
            Console.Read();

        }
    }
}

