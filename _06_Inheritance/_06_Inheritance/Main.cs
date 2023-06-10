namespace _06_OOP_Ilkeleri { 

internal class MainClass { 

static void Main(string[] arg)
{
            //Civciv kus = new Civciv();
            //kus.Ad = "oskar";
            //kus.Ot(); 
            //kus.Beslen();
            //ust satirdaki islem istenmeyen bir islemdir cunku baska bir kus cesidini almak istedigimizde cekirdek kod(main) icerisindeki kodu degistiriyoruz ama bizim buradaki kodu
            //sabit tutup child classlar ile islem yapmamiz gerekiyordu bu surecte oop ye basvuruyoruz ...
            //ve child classlarda kod tekrarina gittik eger tum kus turlerini yazmamiz gerekseydi yanlis bir yontem olurdu suan yazilan kodlar.

            MuhabbetKusu muhabbetKusu = new MuhabbetKusu();
            CekirdekKod(muhabbetKusu);

            static void CekirdekKod(Kus kus)
            {
             
                kus.Ad = "oskar";
                kus.Ot();
                kus.Beslen();
                kus.Uc();


            }


        }
    }
}