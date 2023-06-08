using System;
using static _05_DelegateEvent.Event_Insan_;

namespace _05_DelegateEvent
{
	public class Isveren
	{
		//public delegate void OlayTipi();
		public event OlayTipi IsGeldi;

		public void BasladikBilgisiVer()
		{
			Console.WriteLine("sayin musterimiz urununuz icin calismaya basladik");
		}
		public void OrtasindayizBilgisiVer()
		{
			Console.WriteLine("sayin musterimiz urununuz kisa surede hazir olacaktir");
		}
		public void UrununuzHazir()
		{
			Console.WriteLine("sayin musterimiz urununuz hazir");
		}
		public void IsDagit()
		{
			IsGeldi();
		}
	}
}

