 

namespace _05_DelegateEvent
{
		//karsilikli etki-tepki olay surecine event denir
		//Event de 2 sey onemlidir; tanimlar ve senaryo ...

    public class Insan //Insan class i olusturduk 
	{
		public string Ad { get; } //bu insanin adi olmasi icin read only property olusturduk 

		public Insan(string ad)  //baslangicta olusturdugumuz property bizim belirledigimiz isimde olsun diye bir constructor olusturduk 
		{
			Ad = ad;
		}

		public delegate void GenelOlay(Insan i); //burada olaylari gostermek icin methodlari kullanicaz bunun karsiligi olarak etki eden kisiyi belirtmek icin isim vermek yerine obje kullanicaz
												 //buradaki Insan nesnedir class olan Insan degildir.
		public event GenelOlay BiriBanaVurdu;
		public event GenelOlay BiriniDovdum;
		public event GenelOlay BirineKizdim; //eventleri event olarak belirtiriz. methodla event farki da methodlar invoke edilerek cagirilir . eventler ise sadece bildirme yapar 

		public void BaskasinaVur(Insan baskasi)
		{
			Console.WriteLine("ben {0} ve {1} kisisine vurdum", this.Ad, baskasi.Ad); //this.Ad bizi temsil ediyor . baskasi degiskenine atadigimiz ad da baska birini temsil ediyor
			BiriniDovdum(this);
		}

        public void DayakYe(Insan dayakAtan)
        {
            Console.WriteLine("ben {0} ve {1} kisisi bana vurdu", this.Ad, dayakAtan.Ad); //this.Ad dayan yiyeni temsil ediyor
			BiriBanaVurdu(dayakAtan);
        }
        public void BirineKiz(Insan kizilacak)
        {
            Console.WriteLine("ben {0} ve {1} kisisine kizdim", this.Ad, kizilacak.Ad);
			
        }
    }

}

