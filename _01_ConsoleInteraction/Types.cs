using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _01_ConsoleInteraction
{
	public class Types
	{
		public static void Type()
		{

//primitive types are the basic types of data
//byte, short, int, long, float, double, boolean, char
//primitive variables store primitive values
/*
int = 32 byte yer kaplar tamsayilar icin kullanilir(bunun 1 biti - veya + oldugunu belirtmek icin) 
long = 64 byte yer kaplar daha buyuk tamsayilar icindir
double = 2.5 gibi ondalikli sayilar icin kullanilir
float = 2.5 yapamayiz cunku daha buyuk bir sayiyi float turu gibi daha kucuk alana yaziyoruz burada implicit conversion yapamayiz cunku double bir degeri floata atiyoruz onun yerine 2.5F seklinde kullanabiliriz
DateTime tarih = new DateTime(2023,05,22) formatinda yazabiliriz ihtiyaca gore diger formatlari da method overload kismindan gorebiliriz
char tekKarakter = 'b' tek bir karakter icin yazabiliriz, tek tirnak kullanilir ve stack de saklanir o yuzden primitive tiptir fakat cok karakterli string ref olarak gecer 
*/

//reference types are any instantiable class as well as arrays
//String, Scanner, Random, Die, int[], String[],Object,Array etc.
//reference variables store addresses
/* 
string cokKarakter = "merhaba" coklu metinler icin kullaniriz cift tirnak ile ifade ederiz
object nesne = new object(); object bir ref type tir , en buyuk alan objecte aittir . istedigimiz atamalari objecte yapabiliriz fakat bu sefer boxing durumu olusur
(boxing alanini bilmedigimiz bir type a ornegin int atamasi yaptigimiz zaman olusur bunu unboxing yapmamiz gerekiyor onu da altta gorebiliriz)
nesne = sayi; // boxing var
int sayi2 = nesne; // boxing var
int sayi2 = (int)nesne; // unboxing haline dondurduk yani nesneye turunu hatirlattik artik alani belli oldugu icin unboxingtir .


*/
		
        }
	}
}

