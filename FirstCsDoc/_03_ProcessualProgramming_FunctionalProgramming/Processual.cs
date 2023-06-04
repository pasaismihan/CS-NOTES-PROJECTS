using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _03_Processual
{
	public class Processual
	{
		public static void ProcessualProgramming()
		{
			//prosedurel programlamada kodu bir akis halinde yazariz cekirdek kod bolumunu olustururuz oncesinde , daha sonra bu methodlardan olusan kodlarin icerigini olustururuz ornegin ;

			// EKRANDAN OKUNAN IKI TAM SAYIYI KARSILASTIR
			// -- Birinci sayiyi al
			int birinciSayi = EkrandanSayiOku("birinci sayiyi giriniz");

            // -- Ikinci sayiyi al
            int ikinciSayi = EkrandanSayiOku("ikinci sayiyi giriniz");

			// --Karsilastir
			string karsilastirmaMetni = Karsilastir(birinciSayi, ikinciSayi);

			// --Sonucu ekrana yaz
			EkranaYaz(karsilastirmaMetni);

			// --Bekle
			Bekle();
        }

        private static void Bekle()
        {
            Console.Read();
        }

        private static void EkranaYaz(string karsilastirmaMetni)
        {
            Console.WriteLine(karsilastirmaMetni);
        }

        private static string Karsilastir(int birinciSayi, int ikinciSayi)
        {
            if (birinciSayi > ikinciSayi)
            {
                return "birinci sayi ikinci sayidan buyuktur";
            }
            else if (ikinciSayi > birinciSayi)
            {
                return "ikinci sayi birinci sayidan buyuktur";
            }
            else
            {
                return "sayilar esittir";
            }
        }

        private static int EkrandanSayiOku(string ekranMesaji)
        {
            //karsilamayi yaz
            EkranaYaz(ekranMesaji);
            //ekrandan deger oku
            string input = EkrandanOku();
            //degeri sayiya cevir
            int sayi;
            bool donustuMu = sayiyaDonustuMu(input, out sayi);
            //degeri don
            if (donustuMu)
            {
                return sayi;
            }
            else
            {
                throw new Exception("hatali giris");
            }
        }

        private static string EkrandanOku()
        {
            return Console.ReadLine();
        }

        private static bool sayiyaDonustuMu(string input, out int sayi)
        {
            sayi = 0;
            try
            {
                sayi = int.Parse(input);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

