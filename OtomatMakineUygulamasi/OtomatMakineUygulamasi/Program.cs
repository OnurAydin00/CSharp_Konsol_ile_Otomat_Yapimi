using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomatMakineUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cizgi = new string('-', 5);
            string baslikBoslugu = new string(' ', 33);
            string ucretGirisBoslugu = new string(' ', 27);
            string ucret = new string(' ', 7);
            string menuBoslugu = new string(' ', 12);
            string menuArasiYaziBosluk = new string(' ', 42);
            string islemMenusu = new string(' ', 40);
            string cikisIcinBosluk = new string(' ', 45);
            int minimum = 2;
            //------------------FİYATLAR---------------
            double coca = 5;
            double hanımEller = 10;
            double fanta = 4.5;
            double topKek = 3;
            double sprite = 4;
            double burcakBiskuvi = 7;
            double yediGun = 8;
            double biskrem = 5;
            double frukoGazoz = 7.5;
            double halley = 3;
            double pepsi = 8;
            double hosbesFindikli = 9;
            double cappyVisne = 10;
            double hosbesKakaolu = 9;
            double cappySeftali = 10;
            double bitterCikolata = 2.5;
            double cappyKayisi = 10;
            double ulkerCikolata = 2.5;
            double limonata = 5;
            double tuzluFistik = 8.5;
            double sicakCikolata = 4.5;
            double sosluFistik = 9.5;
            double su = 1.5;
            double cubukKraker = 3.5;
            double soda = 5;
            double ciziKraker = 3.5;
            double sogukCay = 5.5;
            double susamliCubukKraker = 3.5;
            double ihlamur = 10;
            double cips = 11;

        tekrar:

            Console.WriteLine(baslikBoslugu + cizgi + "Otomat Makinesi" + cizgi); // Başlık
            Console.WriteLine(); // Boşluk oluşturduk

            Console.Write(ucretGirisBoslugu + "Para Girişi: ");
            double para = Convert.ToDouble(Console.ReadLine()); //-----Buradaki decimal değişkeni double olarak değiştirebiliriz. Buraya bakılacak.

            if (para >= 1.5)
            {
                Console.WriteLine(); // Alt Satır

                Console.Clear(); // Para girişi yapıldıktan sonra konsol temizlensin ve temiz bir ekran çıksın.

            menuIcerigi:

                Console.WriteLine(baslikBoslugu + cizgi + "Otomat Makinesi" + cizgi + "\n\n" + baslikBoslugu + ucret + "Paranız: {0} TL", para); // Başlık

                Console.WriteLine(menuBoslugu + "İçecekler" + menuArasiYaziBosluk + " Yiyecekler"); // Menü içeriği
                Console.WriteLine(menuBoslugu + "-----------" + new string(' ', 41) + "------------"); // Menu içeriği çizgisi
                Console.WriteLine(menuBoslugu + " 1-Coca-Cola Kutu 250 ml --- " + coca + " TL" + new string(' ', 20) + "16-Ülker Hanımeller Tuzlu Karma Poşet 150 gr --- " + hanımEller + " TL\n" + menuBoslugu + " 2-Fanta 250 ml --- " + fanta + " TL" + new string(' ', 26) + " 17-Eti Topkek Kakaolu --- " + topKek + " TL\n" + menuBoslugu + " 3-Sprite 250 ml --- " + sprite + " TL" + new string(' ', 28) + "18-Eti Burçak Bisküvi --- " + burcakBiskuvi + " TL\n" + menuBoslugu +
                    " 4-Yedigün Portakal Meyveli Gazoz 1 lt --- " + yediGun + " TL" + new string(' ', 6) + "19-Ülker Biskrem Kakaolu --- " + biskrem + " TL\n" + menuBoslugu + " 5-Fruko Gazoz 1 lt --- " + frukoGazoz + " TL \t\t\t 20-Ülker Halley 30 gr --- " + halley + " TL\n" + menuBoslugu + " 6-Pepsi Kola Kutu 250 ml --- " + pepsi + " TL" + new string(' ', 18) + " 21-Eti Hoşbeş Gofret Fındıklı --- " + hosbesFindikli + " TL\n" + menuBoslugu +
                    " 7-Cappy Meyve Suyu Vişne 1 lt --- " + cappyVisne + " TL" + new string(' ', 13) + "22-Eti Hoşbeş Gofret Kakaolu --- " + hosbesKakaolu + " TL\n" + menuBoslugu + " 8-Cappy Meyve Suyu Şeftali 1 lt --- " + cappySeftali + " TL" + new string(' ', 10) + " 23-Ülker Bitter Çikolata 36 gr --- " + bitterCikolata + " TL\n" + menuBoslugu + " 9-Cappy Meyve Suyu Kayısı 1 lt --- " + cappyKayisi + " TL" + new string(' ', 12) + "24-Ülker Çikolata 36 gr --- " + ulkerCikolata + " TL\n" +
                    menuBoslugu + " 10-Limonata 1 lt --- " + limonata + " TL" + new string(' ', 27) + "25-Tuzlu Fıstık --- " + tuzluFistik + " TL\n" + menuBoslugu + " 11-Sıcak Çikolata 200 ml --- " + sicakCikolata + " TL\t\t 26-Soslu Fıstık --- " + sosluFistik + " TL\n" + menuBoslugu + " 12-Su 0.5 lt --- " + su + " TL\t\t\t\t 27-Çubuk Kraker --- " + cubukKraker + " TL\n" + menuBoslugu + " 13-Soda 200 ml --- " + soda + " TL" + new string(' ', 27) + "  28-Ülker Çizi Kraker --- " + ciziKraker + " TL\n" +
                    menuBoslugu + " 14-Soğuk Çay 330 ml --- " + sogukCay + " TL\t\t\t 29-Susamlı Çubuk Kraker 56 gr --- " + susamliCubukKraker + " TL\n" + menuBoslugu + " 15-Ihlamur 200 ml --- " + ihlamur + " TL\t\t\t 30-Cips --- " + cips + " TL");
                Console.WriteLine(cikisIcinBosluk+"0-Çıkış");
                Console.WriteLine(new string(' ', 25) + new String('-', 50) + "\n");

                Console.Write(new string(' ', 40) + "İşleminiz: ");
                int islem = int.Parse(Console.ReadLine());

                switch (islem)
                {
                    case 0:
                        Console.WriteLine("\n"+islemMenusu+"Paranız iade ediliyor...");
                        Console.ReadKey();
                        Console.WriteLine(islemMenusu + "İade Edilen Tutar: {0} TL", para);
                        Console.ReadKey();
                        Console.WriteLine("\n"+islemMenusu+"Çıkış Yapıldı.");
                        break;
                    case 1:
                        if (para >= coca)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= coca;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n"+islemMenusu+"Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu+"Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız! \n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", coca, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 2:
                        if (para >= fanta)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= fanta;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", fanta, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 3:
                        if (para >= sprite)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= sprite;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", sprite, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 4:
                        if (para >= yediGun)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= yediGun;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", yediGun, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 5:
                        if (para >= frukoGazoz)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= frukoGazoz;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", frukoGazoz, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 6:
                        if (para >= pepsi)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= pepsi;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", pepsi, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 7:
                        if (para >= cappyVisne)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= cappyVisne;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", cappyVisne, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 8:
                        if (para >= cappySeftali)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= cappySeftali;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", cappySeftali, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 9:
                        if (para >= cappyKayisi)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= cappyKayisi;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", cappyKayisi, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 10:
                        if (para >= limonata)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= limonata;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", limonata, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 11:
                        if (para >= sicakCikolata)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= sicakCikolata;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", sicakCikolata, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 12:
                        if (para >= su)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= su;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", su, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 13:
                        if (para >= soda)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= soda;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", soda, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 14:
                        if (para >= sogukCay)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= sogukCay;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", sogukCay, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 15:
                        if (para >= ihlamur)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, içeceğinizi alabilirsiniz.\n");
                            para -= ihlamur;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "İçecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", ihlamur, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 16:
                        if (para >= hanımEller)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= hanımEller;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", hanımEller, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 17:
                        if (para >= topKek)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= topKek;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", topKek, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 18:
                        if (para >= burcakBiskuvi)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= burcakBiskuvi;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", burcakBiskuvi, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 19:
                        if (para >= biskrem)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= biskrem;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", biskrem, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 20:
                        if (para >= halley)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= halley;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", halley, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 21:
                        if (para >= hosbesFindikli)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= hosbesFindikli;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", hosbesFindikli, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 22:
                        if (para >= hosbesKakaolu)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= hosbesKakaolu;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", hosbesKakaolu, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 23:
                        if (para >= bitterCikolata)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= bitterCikolata;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", bitterCikolata, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 24:
                        if (para >= ulkerCikolata)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= ulkerCikolata;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", ulkerCikolata, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 25:
                        if (para >= tuzluFistik)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= tuzluFistik;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", tuzluFistik, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 26:
                        if (para >= sosluFistik)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= sosluFistik;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", sosluFistik, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 27:
                        if (para >= cubukKraker)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= cubukKraker;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", cubukKraker, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 28:
                        if (para >= ciziKraker)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= ciziKraker;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", ciziKraker, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 29:
                        if (para >= susamliCubukKraker)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= susamliCubukKraker;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", susamliCubukKraker, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    case 30:
                        if (para >= cips)
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarılı, yiyeceğinizi alabilirsiniz.\n");
                            para -= cips;
                            Console.WriteLine(islemMenusu + "Kalan Paranız: {0} TL", para);
                            if (para > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Para üstü geri veriliyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Para üstü geri verildi. {0} TL", para);
                                break;
                            }
                            else
                            {
                                Console.ReadKey();
                                Console.WriteLine("\n" + islemMenusu + "Çıkış yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış Yapıldı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n" + islemMenusu + "İşlem başarısız!\n\n" + islemMenusu + "Yiyecek Ücreti: {0} TL\n" + islemMenusu + "Bakiyeniz: {1} TL", cips, para);
                            Console.ReadKey();
                            Console.WriteLine("\n" + islemMenusu + "Para iade ediliyor...");
                            Console.ReadKey();
                            Console.WriteLine(islemMenusu + "Para iade edildi.");
                            Console.WriteLine();
                            Console.WriteLine(islemMenusu + "Tekrar denemek ister misiniz? (E/H)");
                            Console.Write(islemMenusu + "İşlem: ");
                            char tekrarDeneme = Convert.ToChar(Console.ReadLine());

                            if (tekrarDeneme == 'e' || tekrarDeneme == 'E')
                            {
                                Console.Clear();
                                goto tekrar;
                            }
                            else if (tekrarDeneme == 'h' || tekrarDeneme == 'H')
                            {
                                Console.WriteLine();
                                Console.WriteLine(islemMenusu + "Çıkış Yapılıyor...");
                                Console.ReadKey();
                                Console.WriteLine(islemMenusu + "Çıkış yapıldı.");

                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Menudeki seçenekleri seçiniz lütfen!");
                        Console.ReadLine();
                        Console.Clear();
                        goto menuIcerigi;
                }
            }
            else
            {
                Console.WriteLine("Bakiyeniz menüdeki fiyatlar için yetersizdir. Lütfen minimum {0} TL para girişi yapın.", minimum);
                Console.ReadKey();
                Console.Clear();

                goto tekrar;
            }

            Console.ReadKey();
        }
    }
}
