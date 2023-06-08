using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _05_Delegate
{
    internal class Delegate
    {
        public delegate void geriDonussuzParametresiz(); //geriDonussuzParametresiz methodun tipidir (degisken tanimlarken int string yapmak gibi) 
        public static void Delegates()
        {
            //c# da method adini verdigimiz islevlerin bellek adreslerini tutmak icin kullanilan yapiya DELEGATE denir
            //delegate ile methodlara esneklik saglariz istedigimiz gibi yonlendirmeye yarar 
            geriDonussuzParametresiz method;
            method = Method1; // Method1 islevini bir degiskene atadik
            method.Invoke(); // degisken sayesinde islevi invoke ettik yani calistirdik
            method = Method2;
            method.Invoke(); // en son degiskene Method2 atandigi icin Method2 calisir
            method += Method1; // void olmasi gerekiyor cunku cift return yapamayiz 
            method.Invoke(); //once Method2 ve Method1 art arda calisir cunku bir ust satirda method degiskenine atama operatoru kullandik artik her iki methodu da calisiracak
            method -= Method2; //Method2 yi siradan cikardik artik calismayacak 
         }

        public static void Method2()
        {
         //
        }

        public static void Method1() //methodun deklare edildigi yer 
        {
            //dddggg
        }

      //Delegate Ornegi !!!
      public string BorcSorgula(int aboneNo)
        {
            return Process(aboneNo,KurumBorcSorgula);
        }

  
        public delegate string KurumServisMethodu(int a); //burada bir delegate tanimi yaptik
        public string Process(int aboneNo , KurumServisMethodu servisMethodu)
        {
            return servisMethodu.Invoke(aboneNo);
        }
        public string KurumBorcSorgula(int aboneNo)
        {
            return "abcdef";
        }
        //yukaridaki delegate tanimlamamizin amaci, delegate olmasaydi her method cagirisimizda loglama yapacaktik fakat bir kere delegate tanimi yapip process icerisinde cagirinca diger methodlarda bunu tekrarladik 

    }
}