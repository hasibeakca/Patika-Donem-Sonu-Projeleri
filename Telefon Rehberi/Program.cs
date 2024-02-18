using System;
using System.Collections;

namespace Telefon_Rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kisiler> rehber = new List<Kisiler>();
            Kisiler kisi1 = new Kisiler("Hasibe", "Akca", "05076666565");
            Kisiler kisi2 = new Kisiler("Furkan", "Akca", "05045456565");
            Kisiler kisi3 = new Kisiler("Ares", "Akca", "05076668989");
            Kisiler kisi4 = new Kisiler("Hades", "Akca", "05075329765");
            Kisiler kisi5 = new Kisiler("Pistos", "Akca", "05089306565");
            rehber.Add(kisi1);
            rehber.Add(kisi2);
            rehber.Add(kisi3);
            rehber.Add(kisi4);
            rehber.Add(kisi5);

            Islemler islemler = new Islemler();
           

            Console.WriteLine("Lütfen bir seçim yapınız:");
            Console.WriteLine(" Yeni kişi eklemek için 1'i \n Bir kişiyi silmek için 2'yi \n Bir numarayı güncellemek için 3'ü \n Rehberi listelemek için 4'ü \n Rehberde bir kişiyi aramak için 5'i tuşlayın:");
            int tuslama = int.Parse(Console.ReadLine());
            if(tuslama == 1)
            {
                Kisiler yeniKisi = new Kisiler();
                islemler.YeniKisiEkle(yeniKisi);
                rehber.Add(yeniKisi);
                Console.WriteLine("Yeni kişi başarıyla eklendi!");
            }
            else if(tuslama == 2)
            {
                islemler.Silme(rehber);

            }else if(tuslama == 3)
            {
                islemler.Guncelleme(rehber);
            }else if( tuslama == 4)
            {
                islemler.Listeleme(rehber);
            }else if(tuslama == 5)
            {
                islemler.Bulma(rehber);
            }

        }
        
    }    
    
}