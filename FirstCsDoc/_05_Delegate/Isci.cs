using System;
using static _05_DelegateEvent.Event_Insan_;

namespace _05_DelegateEvent
{
	public class Isci
	{
        public event OlayTipi IseBasladim;
        public event OlayTipi IsinOrtasindayim;
        public event OlayTipi IsiBitirdim;
        public int Sicil { get; set; }
        public Isci(int sicil)
        {
            Sicil = sicil; 
        }

        public void Calis()
        {
            Console.WriteLine("{0}.sicildeki personelim ve ise basladim",Sicil);
            Thread.Sleep(2000);
            IseBasladim();
            Console.WriteLine("{0}.sicildeki personelim ve isin ortasindayim",Sicil);
            Thread.Sleep(2000);
            IsinOrtasindayim();
            Console.WriteLine("{0}.sicildeki personelim ve isi bitirdim",Sicil);
            Thread.Sleep(2000);
            IsiBitirdim();
            Console.Read();
        }
    }
}

