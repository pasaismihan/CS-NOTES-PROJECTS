using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


namespace _04_ClassObject
{
    //alan kay tarafindan ortaya cikmistir
    //OOP ilkesine gore her sey objedir
    //6 tane prensibi vardir
    /*oop de nesnelerden olusan ortak siniflar belirleriz boylece kod tekrarindan da kacmis oluruz ornegin bir siniftaki kisileri baz alirsak class olarak onlara insan diyebiliriz
    fakat icerisinde bulunan ahmet,mehmet,can birer nesnedir ve ortak olduklari sinif hepsinin insan olmasidir fakat hicbir zaman insan = ahmet olamaz*/
    /*C# dilinde nesnelerin birbirleriyle ilişki kurarken hangi erişim kontrolleri ile çalıştığını bilmeniz önemlidir. Erişim belirleyiciler (access modifiers)
    sınıflara nerelerden ve ne şekilde erişileceğini belirtir.*/

    //Access Modifiers
    //Public: Her yerden erişilebilir.
    //Private: Sadece tanımlandığı sınıf içerisinden erişilebilir.
    //Internal: Sadece bulunduğu projede erişilebilir.
    //Protected: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
    //Protected Internal: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.Ayrıca tanımlamanın aynı proje içerisinde olma şartı yoktur. Protected'dan farkı budur.
    //Eger sinif belirlenmediyse bu internal olarak atanir !!

    internal class Program
    {

        public static void Main(string[] args)
        {
            Insan insan = new Insan();   // Insan classini insan ve insan2 degiskenlerine atayarak birer yeni Insan() constructor u cagiriyoruz   
            Insan insan2 = new Insan();  // Bu sekilde farkli degiskenlere atayabiliriz , suan her ikisinde de islev ayni olsa da bu degiskenlere farkli ozellikler verebiliriz
            insan.Equals(insan2); // false doner cunku ayni objeye baksalar bile farkli degiskenlerdir 
            insan = insan2; // bu durumda her ikisi de ayni add ye bakar bir digerinin referans adresi garbage collector tarafindan yok edilir
            /*eger classlar ayni assembly icerisinde ise bir digerinde cagirmak icin nokta kullanabiliriz . eger farkli assembly icerisinde ise public olmasina dikkat etmeliyiz 
            public oldugunda baska projelerden de erisimimiz oluyor , internal yaparsak da sadece o proje icindeki diger classlara erisim saglanir*/
            //Ayni namespace ile yapilan projelerde direkt olarak namespace kullanmadan cagirma yapabiliriz buyuk projelerde yontem bu sekildedir !!!

        }
        public class Insan
        {
            //bu sekilde bir class olusturduk fakat bu class in bellege cikmasi icin main icerisinde new keywordu ile tanimlanmasi gereklidir , buna instance alma denir !!!
            //CLASS MEMBER CESITLERI
            //method - islev gorevi gorur
            //field - hafiza anlamina gelir genelde private(sadece ilgili classta calisan) bunu public yapip baska bir projede kullanmak icin farkli bir method ile cagiririz
            //property - fieldin accessorler araciligiyla ulasilabilir olmasini saglar 
            //Constructor - heap e cikarken yapilacaklari soyler ornegin main bolumunde Insan classini kullanarak direkt olarak constructora atama yapabiliriz boylelikle constructor member scopunu olusturdugumuzda o atamayi cagiririz 
            //Destructor - bir methodun olme sirasinda yapilmasi gerekenler (bu scope icerisinde olusturulan islem veya nesneler o constructor la birlikte yok olur )
            //Event - ileri OOP de goruruz . nesneler arasinda etki-tepki olusturmak icin kullanilir 
            private string ad; // field ornegi (bunu baskalarina acmayiz bize ozel bir sey)

            public string AdiniSoyle() // get accessor - ilgili degeri alip disari veriyor 
            {
                return ad; //ilgili field i bu sekilde farkli bir projede kullanmak uzere bir islev katariz 
            }

            public void AdiniOgren(string yeniad) // set accessor - disaridaki degeri ilgili fielda atiyor 
            {
                if (ad == null)
                {
                    ad = yeniad; // bu sekilde tekrar tekrar ad guncellenebilir bu yuzden kontrol mekanizmasi eklememiz gerekiyor
                }
                else
                {
                    throw new Exception("benim zaten bir adim var!");
                }
            } // eger ad yoksa yeni bir ad olustur , varsa da hata mesaji gonder diye bir kontrol mekanizmasi olusturduk

        //Ustteki gibi ayri ayri get ve set accessorler yapmak yerine PROPERTY adini verdigimiz bir kavram cikmistir bunun amaci fielda get ve set accessorlerini vermesi !!!!!!!!!!!

            public string Ad { get { return ad; } set
                {
                    if (ad == null)
                    {
                        ad = value; // set accessor de default olarak verilen value keywordu parametre gibi kullanilir  
                    }
                    else
                    {
                        throw new Exception("benim zaten bir adim var!");
                    }
                }
            }
            // public string Ad { get; } - ad fieldi icin sadece okuma yapabilir atama yapilamaz seklinde kullandigimiz Property (Read Only Property)
            // public string Ad {get; set;} - full property 

            //class ve nesne baglantisinda olusturdugumuz insan degiskenini kullanarak bir field verebiliriz yani ; (bu bolumu main icerisinde yapmamiz gerekiyor konu butunlugunden dolayi buraa yaptik)
            string ilgiliKisininAdi = insan.Ad;

            string siradakiKisininAdi = "pasa";
            insan.Ad = siradakiKisininAdi; //burada pasa ismini ilgili fielda propery yoluyla set accessor atamasi yapiyoruz . set accessordaki value degeri de siradakiKisininAdi oluyor 

        //field ve degisken arasindaki fark - fieldin insan classinin olustugu scope kadardir. degiskenin ise deklare edildigi yer kadardir
        //birde field ve degiskenin kullanim amaci farklidir. degisken bir islevi yaparken kullandigimiz kisa sureli hafiza birimidir fakat field insan class i var oldugu surece devam eder

                //CONSTRUCTOR
                public Insan()
                {
                    //heap e cikarken yapilacaklar (yukarida olusturdugumuz nesne aslinda bir constructor dir)
                }
                
                public Insan(string ad) // bu islem bir kere calisir 
                {
                    Agla();
                    NefesAl();
                    this.ad = ad; //ilk kullanilan ad this keywordu ile birlikte kullanilir ilgili insan scopunun ad fieldi anlamina gelir , ikinci ad ise verdigimiz parametre 
                }

            //eger mainde Insan pasa = new Insan("pasa") yapsaydik bir ust satirda yapmis oldugumuz constructoru tetiklemis olurdu oradaki "pasa" parapetre olan ad i temsil ediyor

            private void NefesAl()
            {
                throw new NotImplementedException();
            }

            private void Agla()
            {
                throw new NotImplementedException();
            }
        }
    }
}