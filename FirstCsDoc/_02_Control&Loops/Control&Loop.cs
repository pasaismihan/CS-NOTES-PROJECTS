using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace _02_Control
{
    internal  class Control
{
    static void Main(string[] args)
    {
            // control ifadeleri birlestirmek icin &&(ve) , ||(veya) kullaniyoruz . bunlari & veya | ile de kullanabiliriz fakat kullanim farki vardir
            // cift && oldugunda 2 ifadeden ilki eger false donerse ikinci ifadeyi hic calistirmaz program.
            // tek & oldugunda ise iki ifadeden birisi false olsa bile diger ifadeyi de calistirir fakat sonuc yine ayni gelir

            /* 3 adet kirici keyword vardir bunlar return , continue , break 
            break -> bulundugun blogun calistirmasini birak
            continue -> bulundugu satirin altindaki kodlari calistirma blogun basina don
            return -> scobu kirmaya yariyor fakat en ust scopa kadar gidiyor en ustte method var ise onun scopunu da kiriyor 
            */


            //arraylar cs de 2 farkli sekilde ifade edilirler (ayni turdeki value lerin tek bir degisken altinda toplanmasi)
            /* 
            ilk olarak degisken deklerasyonu yapariz int[] sayilar = int[5] bu ifade sayilar degiskeninin 5 adet elemani olacagini belirdir
            sonrasinda elemanlarini belirtiriz;
            sayilar[0] = 5;
            sayilar[1] = 20;
            sayilar[2] = 55;
            ...
            */
            //Yada tek bir satirda yapmak istersek int[] sayilar2 = {5,20,55}

            // referans atamalari vardir bunlardan array turunde bir degiskeni ayni array turundeki baska bir degiskene esitledigimizde her ikisi de ayni heap adresinden referans alirlar 

            //ozellik bulmak icin 3 tipten yararlanabiliriz , tpye uzerinden , variable uzerinden ve external(harici) olarak
            //type uzerinden dedigimizde ornegin int baz alirsak int. yaparsak o tip icin gelecek olan ozellikleri karsimiza cikarir
            int a;
            int.Parse("5");// parse metinsel ifadeleri sayiya donusturur
            //variable(degisken) uzerinden yaparsak a. seklinde arattigimizda karsimiza degiskenle ilgili gelebilecek ozellikleri cikarir
            //a.CompareTo(4);
            // external (harici) olarak dis kutuphanelerden kaynakli ozellikler vardir ornegin Math
            Math.Floor(5.5);

            //string.Format cok kullanilan bir methoddur, bunun icerisinde yazilan degerlerle islem yapilabilir
            string ad = "pasa";
            string.Format("benim adim {0},soyadim {1}, yasim{2}", ad, "ismihan", 28); //ilk metinde index numarasini veriyoruz sonrasinda sirayla o indexlere degerleri atiyoruz 



            



    }
}

    }