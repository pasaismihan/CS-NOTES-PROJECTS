﻿using System;
namespace _06_OOP_Ilkeleri
{
	internal class MuhabbetKusu:Kus //kalitimdan gelen kodlarin calismasi icin muhabbetkusuna sen bir kussun demek icin :Kus yaptik 
	{
        //burada bulunan kodlari sildik onun yerine kalitimda virtual keywordu ile izin verdigimiz methodlari ezmek icin bu class da override keywordunu kullaniyoruz

        public override void Beslen()
        {
            string verilen = Console.ReadLine();
            if (verilen == "yem" || verilen == "meyve")
            {
                Console.WriteLine("yedim");
            }
            else
            {
                base.Beslen();
            }
        }

        public override void Ot()
        {
            Console.WriteLine("babacik,cicikus");
        }
    }
}

