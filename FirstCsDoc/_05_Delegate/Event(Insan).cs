using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _05_DelegateEvent
{
	internal class Event_Insan_
	{
		static void Main(string[] arg)
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

			 
		}
	}
}

