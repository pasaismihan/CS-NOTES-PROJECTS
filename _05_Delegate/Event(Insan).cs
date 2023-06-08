using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _05_DelegateEvent
{
   
    public class Event_Insan_
    {
        public delegate void OlayTipi();
        public static void Main(string[] arg)
		{


			Insan pasa = new Insan("PASA");
			Insan mustafa = new Insan("MUSTAFA");
			Insan osman = new Insan("OSMAN");

			//pasa.BaskasinaVur(mustafa);
			//mustafa.DayakYe(pasa);
			//osman.BirineKiz(pasa); //burada bizzat olaya mudahale ediyoruz fakat bizim istedigimiz senaryo olusturmak

			//senaryo
			pasa.BiriniDovdum += mustafa.DayakYe; // atamanin solundaki olay sagindaki de methoddur  
			mustafa.BiriBanaVurdu += osman.BirineKiz;

			pasa.BaskasinaVur(mustafa); //olaylari tetikleyen kisim burasidir. geri kalan senaryo kendiliginden gelisecek  

			Console.Read();


			// BURADA ISCI ISVEREN ORNEGINI AYAGA KALDIRIYORUZ (SENARYOYU YAZIYORUZ)
			Isveren isveren = new Isveren();
			Isci[] isciler = new Isci[10];
			for (int i = 0; i < isciler.Length; i++)
			{
				isciler[i] = new Isci(i + 1);
							isveren.IsGeldi += isciler[i].Calis;
				isciler[i].IseBasladim += isveren.BasladikBilgisiVer;
				isciler[i].IsinOrtasindayim += isveren.OrtasindayizBilgisiVer;
				isciler[i].IsiBitirdim += isveren.UrununuzHazir;
               
            }
            isveren.IsDagit();
            Console.Read();



        }
	}
}

