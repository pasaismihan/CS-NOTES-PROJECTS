using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using _03_Processual;

namespace _03_Methods {

    internal class Methods
    {
    public static void Main(string[] args)
        {
          _03_Processual.Processual.ProcessualProgramming();
        //parametreli method ornekleri ...
        // method kullanirken method ismi , parametre sayilari ve parametre tipi  tamamina method signature deriz 
        }

        //geri donuslu parametreli method
        public static int Topla(int sayi1, int sayi2)
        {
            int toplam;
            toplam = sayi1 + sayi2;
            return toplam;
        }
        //geri donuslu parametresiz method
        public static double PiSayisiniVer()
        {
            return Math.PI;
        }
        //geri donussuz parametreli method
        public static void EkranaYaz(string metin)
        {
            if (string.IsNullOrWhiteSpace(metin)) // string icerisinde bosluk veya null varsa almamak icin bu string ozelligini kullanabiliriz 
            {
                return;
            }
            Console.Write(metin);
        }
        //ayni isi yapan methodlari ayni isimle kullanabiliriz(parametrelerini degistirerek) . burada farkli isimler kullanarak karmasiklik yapmaktan kaciniyoruz!!
        // eger iki sayiyi topluyorsak ve baska bir method da uc sayiyi toplamak istersek o method icerisinde diger methodumuzu kullanabiliriz
        public static int Topla(int sayi1 , int sayi2 , int sayi3)
        {
            int toplam;
            toplam=  Topla(sayi1 , sayi2) + sayi3;
            return toplam;
        }
        public static int ToplaDizi(params int[] sayilar) // buradaki params keywordu ; ne kadar parametre yazarsak yazalim bunlari dizi icerisine yazar ve bunu parametre olarak gonderir 
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {

                toplam += sayilar[i];

            }
            return toplam;
        }
        /* out keywordu bir method yazarken method disinda bir degisken tanimladiysak ve int parametre oncesinde out kullanirsak out sayesinde int parametremiz ref type oluyor bundan dolayi
        her ikisi de ayni degere bakiyorlar . bu iliskide disaridaki degisken parametreye baglidir parametre her degistiginde disaridaki degiskenin degeri de degisir */

        // ref keywordu out keywordunun tam tersidir icerideki parametre disaridaki degiskene baglidir . degiskenin degeri her degistiginde parametrenin degeri de degisir
        // arraylarda ekleme cikarma yapamayiz ama array.Resize ile disaridaki dizinin elemanlarini iceri aktarabiliriz bunu da yine ref ile yapariz 
    }
}