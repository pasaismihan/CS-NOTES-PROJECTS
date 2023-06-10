using System;
namespace _06_OOP_Ilkeleri
{
	internal class Civciv:Kus
	{
		//buradaki kodlari kalitim class da kullandigimiz icin silmemize gerek yok 
		public void Ot()
		{
			Console.WriteLine("cik cik");
		}

		public void Beslen()
		{
			string verilen = Console.ReadLine();
			if(verilen== "yem")
			{
				Console.WriteLine("yedim");
			}
		}

	}
}

