using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    public class Islemler
    {
        public void YeniKisiEkle(Kisiler yeniKisi)
        {
            Console.Write("Kisinin adını giriniz : ");
            yeniKisi.isim = Console.ReadLine();
            Console.Write("Kisinin soyadını giriniz : ");
            yeniKisi.soyisim = Console.ReadLine();
            Console.Write("Kisinin numarasını giriniz : ");
            yeniKisi.telNo = Console.ReadLine();

        }
        public void Silme(List<Kisiler> rehber)
        {
        head:

            Console.WriteLine("Lütfen silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string silinecek = Console.ReadLine();
            bool silindi = false;
            while (true)
            {

                for (int i = 0; i < rehber.Count; i++)
                {
                    if (rehber[i].isim.ToLower() == silinecek.ToLower() || rehber[i].soyisim.ToLower() == silinecek.ToLower())
                    {
                        Console.WriteLine("{0} adlı kişi silinmek üzere emin misiniz?(y/n)", rehber[i].isim);
                        string sonKarar = Console.ReadLine();
                        if (sonKarar == "y")
                        {
                            rehber.RemoveAt(i);
                            Console.WriteLine("Kişi başarıyla silindi!");
                            silindi = true;
                            break;

                        }
                        else if (sonKarar == "n")
                        {
                            Console.WriteLine("Silinme iptal edildi.");
                            silindi = true; // aşağıdaki if için
                            break;
                        }
                    }

                }
                

                if (!silindi)
                {
                    Console.WriteLine("Lütfen tekrar deneyin bahsettiğiniz isim bulunamadı");
                    goto head;
                }

                break;

            }

        }
        public void Guncelleme(List<Kisiler> rehber)
        {
        head:
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını giriniz: ");
            string ad = Console.ReadLine();
            string yeniTelNo;
            bool guncellendi = false;
            while (true)
            {
                foreach (Kisiler item in rehber)
                {
                    if (item.isim.ToLower() == ad.ToLower())
                    {
                        Console.WriteLine("Lütfen yeni telefon numarasını giriniz :");
                        yeniTelNo = Console.ReadLine();
                        item.telNo = yeniTelNo;
                        Console.WriteLine("{0} isimli kişinin telefon numarası başarıyla güncellenmiştir.", item.isim);
                        guncellendi = true;
                        break;
                    }
                }
                if (!guncellendi)
                {
                    Console.WriteLine("Aradığınız kriterlere uygun kişi bulunamadı.\n Yeniden denemek için 1'i \n Güncelleme işlemini sonlandırmak için 2'yi tuşlayınız");
                    int deneme = int.Parse(Console.ReadLine());
                    if (deneme == 1)
                    {
                        goto head;
                    }
                    else if (deneme == 2)
                    {
                        Console.WriteLine("Güncelleme işlemi sonlandırılıyor");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Uygun bir seçim yapmadınız");
                        break;
                    }
                }
                break;
            }

        }
        public void Listeleme(List<Kisiler> rehber)
        {
            Console.WriteLine("Hangi formatta listelensin: \n 1- A-Z  \n 2- Z-A");
            int format = int.Parse(Console.ReadLine());
            if (format == 1)
            {
                rehber.Sort((x, y) => string.Compare(x.isim, y.isim));

            }
            else if (format == 2)
            {
                rehber.Sort((x, y) => string.Compare(y.isim, x.isim));

            }
            else
            {
                Console.WriteLine("Doğru bir seçim yapmadınız varsayılan olarak listeleme yapılacaktır.");
            }
            foreach (Kisiler kisi in rehber)
            {
                Console.WriteLine($"{kisi.isim} {kisi.soyisim}: {kisi.telNo}");

            }
        }
        public void Bulma(List<Kisiler> rehber)
        {
        head:
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1) Telefon numarasına göre arama yapmak için: (2)");
            int aramaSecimi = int.Parse((Console.ReadLine()));
            if (aramaSecimi == 1)
            {
                Console.WriteLine("İsim veya soyisim giriniz : ");
                string adveyaSoyad = Console.ReadLine();
                int temp = -1;
                for (int i = 0; i < rehber.Count; i++)
                {
                    if (adveyaSoyad.ToLower() == rehber[i].isim.ToLower() || adveyaSoyad.ToLower() == rehber[i].soyisim.ToLower())
                    {

                        temp = i;

                    }
                }

                if (temp != -1)
                {
                    Console.WriteLine(rehber[temp].isim + " " + rehber[temp].soyisim
                        + " " + rehber[temp].telNo);
                }
                else
                {
                    Console.WriteLine("Bu isimde veya soyisimde kayıtlı bir kişi bulunamadı.");
                }

            }
            else if (aramaSecimi == 2)
            {
                string arananTelNo = Console.ReadLine();
                int temp = -1;
                for (int i = 0; i < rehber.Count; i++)
                {
                    if (arananTelNo == rehber[i].telNo)
                    {
                        temp = i;
                        break;
                    }

                }

                if (temp != -1)
                {
                    Console.WriteLine(rehber[temp].isim + " " + rehber[temp].soyisim
                        + " " + rehber[temp].telNo);
                }
                else
                {
                    Console.WriteLine("Bu numara ile kayıtlı bir kişi bulunamadı.");
                }

            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız lütfen tekrar deneyin.");
                goto head;
            }
        }
    }
}
