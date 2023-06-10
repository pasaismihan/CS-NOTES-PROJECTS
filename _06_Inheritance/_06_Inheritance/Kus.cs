namespace _06_OOP_Ilkeleri
{
    internal class Kus
    {
        //her kus turunde ortak olan kodlari cekirdek koda topladik 
        private string ad;
        public string Ad { get { return ad; } set { ad = value; } }

        public Kus() //bir nesnemiz dogdugunda yapilacak islemler icin constructor kullaniyorduk yani new Kus() diye olusturdugumuzda nefes almaya basla diye bir komut verdik 
        { 
            //NefesAl();
        }
        private void NefesAl() //constructor ile public yaparak kapi actik (encapsulation)
        {
            //asdasds
        }

        public void Uc()
        {
            //bla bla
        }


        /*alttaki kodlarda her kus icin ortak ozellikler var fakat icerigi farkli karga cik cik otmez gibi . bu durumda polymorphism dedigimiz ilkeyi kullanip kalitimda kullandigimiz
        kodlari kus cesidine gore ezecegiz bunun icin !!virtual!! keywordunu kalitim class inda kullaniyoruz(alttaki satirda) */
        public virtual void Ot()
        {
            Console.WriteLine("cik cik");
        }

        public virtual void Beslen()
        {
            string verilen = Console.ReadLine();
            if (verilen == "yem")
            {
                Console.WriteLine("yedim");
            }
        }

    }
}

