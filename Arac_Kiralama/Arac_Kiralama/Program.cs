using System;

namespace Arac_Kiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            string gunluk_mu_saatlik_mi = null;
            string devam_mi = null;

            while (true)
            {
                if (gunluk_mu_saatlik_mi == "2")
                {
                    break;
                }
                else if (devam_mi == "0")
                {
                    break;
                }
                string arac_secimi;
                Console.Write("ARAÇLARIMIZ\n\tVolkswagen-1\tMercedes-2\tRenault-3\tÇıkış-Q\n\tSeçiminiz: ");
                arac_secimi = Console.ReadLine();

                if (arac_secimi == "Q" || arac_secimi == "q")
                {
                    Console.WriteLine("Yine bekleriz...");
                    break;
                }
                else if (arac_secimi == "1")
                {
                    Console.WriteLine("Volkswagen Fiyat Listesi\n\tSaatlik : 50TL Günlük : 1.000TL Aylık : 28.000TL\n");
                    DateTime teslim_alinacak_gun;
                    Console.Write("Teslim alınacak günü (gün.ay.yıl) olarak giriniz: ");
                    teslim_alinacak_gun = Convert.ToDateTime(Console.ReadLine());

                    DateTime teslim_edilecek_gun;
                    Console.Write("Teslim edilecek günü (gün.ay.yıl) olarak giriniz: ");
                    teslim_edilecek_gun = Convert.ToDateTime(Console.ReadLine());

                    if (teslim_alinacak_gun == teslim_edilecek_gun)
                    {
                        while (true)
                        {
                            float alinacak_saat, verilecek_saat;
                            Console.Write("Aracı teslim alacağınız saat: ");
                            alinacak_saat = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Aracı teslim edeceğiniz saat: ");
                            verilecek_saat = Convert.ToSingle(Console.ReadLine());

                            if (verilecek_saat > alinacak_saat)
                            {
                                float kullanilacak_saat;
                                float tutar = 0;
                                kullanilacak_saat = verilecek_saat - alinacak_saat;
                                tutar = kullanilacak_saat * 50;
                                Console.WriteLine("Toplam bakiyeniz: " + tutar);

                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();

                                while (devam_mi != "1" && devam_mi != "0")
                                {
                                    Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                    Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                    devam_mi = Console.ReadLine();
                                }
                                if (devam_mi == "0")
                                {
                                    break;
                                }
                                else if (devam_mi == "1")
                                {
                                    break;
                                }
                            }
                            else if (verilecek_saat == alinacak_saat)
                            {
                                Console.WriteLine("Araçlarımız en az 1 saat kiralanabilir.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Teslim alınacak saat teslim edilecek saatten büyük olamaz.\nDilerseniz günlük kiralayabilirsiniz.\n");
                                Console.Write("Günlük kiralamak için-1 Çıkış-2: ");
                                gunluk_mu_saatlik_mi = Console.ReadLine();

                                while (gunluk_mu_saatlik_mi != "1" && gunluk_mu_saatlik_mi != "2")
                                {
                                    Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                    Console.Write("Günlük kiralamak için-1 Çıkış-2: ");
                                    gunluk_mu_saatlik_mi = Console.ReadLine();
                                }
                                if (gunluk_mu_saatlik_mi == "2")
                                {
                                    break;
                                }
                                else if (gunluk_mu_saatlik_mi == "1")
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else if (teslim_edilecek_gun > teslim_alinacak_gun && (Convert.ToInt32(teslim_edilecek_gun.Day - teslim_alinacak_gun.Day) < 30 && (teslim_edilecek_gun.Month - teslim_alinacak_gun.Month == 0)))
                    {
                        while (true)
                        {
                            int kullanilacak_gun;
                            float tutar = 0;

                            TimeSpan ts = teslim_edilecek_gun - teslim_alinacak_gun;
                            kullanilacak_gun = ts.Days;
                            Console.WriteLine("Kiralanacak Gün: " + kullanilacak_gun);
                            tutar = kullanilacak_gun * 1000;
                            Console.WriteLine("Toplam bakiyeniz: " + tutar);

                            Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                            devam_mi = Console.ReadLine();

                            while (devam_mi != "1" && devam_mi != "0")
                            {
                                Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();
                            }
                            if (devam_mi == "0")
                            {
                                break;
                            }
                            else if (devam_mi == "1")
                            {
                                break;
                            }
                        }
                    }
                    else if (teslim_edilecek_gun > teslim_alinacak_gun && Convert.ToInt32(teslim_edilecek_gun.Month - teslim_alinacak_gun.Month) != 0)
                    {
                        while (true)
                        {
                            int kullanilacak_ay;
                            float tutar = 0;

                            TimeSpan ts = teslim_edilecek_gun - teslim_alinacak_gun;
                            kullanilacak_ay = ts.Days;
                            Console.WriteLine("Kiralanacak Gün: " + kullanilacak_ay);
                            tutar = kullanilacak_ay * 28000;
                            Console.WriteLine("Toplam bakiyeniz: " + tutar);

                            Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                            devam_mi = Console.ReadLine();

                            while (devam_mi != "1" && devam_mi != "0")
                            {
                                Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();
                            }
                            if (devam_mi == "0")
                            {
                                break;
                            }
                            else if (devam_mi == "1")
                            {
                                break;
                            }
                        }
                    }
                }
                else if (arac_secimi == "2")
                {
                    Console.WriteLine("Mercedes Fiyat Listesi\n\tSaatlik : 70TL Günlük : 1.500TL Aylık : 40.000TL\n");
                    DateTime teslim_alinacak_gun;
                    Console.Write("Teslim alınacak günü (gün.ay.yıl) olarak giriniz: ");
                    teslim_alinacak_gun = Convert.ToDateTime(Console.ReadLine());

                    DateTime teslim_edilecek_gun;
                    Console.Write("Teslim edilecek günü (gün.ay.yıl) olarak giriniz: ");
                    teslim_edilecek_gun = Convert.ToDateTime(Console.ReadLine());

                    if (teslim_alinacak_gun == teslim_edilecek_gun)
                    {
                        while (true)
                        {
                            float alinacak_saat, verilecek_saat;
                            Console.Write("Aracı teslim alacağınız saat: ");
                            alinacak_saat = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Aracı teslim edeceğiniz saat: ");
                            verilecek_saat = Convert.ToSingle(Console.ReadLine());

                            if (verilecek_saat > alinacak_saat)
                            {
                                float kullanilacak_saat;
                                float tutar = 0;
                                kullanilacak_saat = verilecek_saat - alinacak_saat;
                                tutar = kullanilacak_saat * 70;
                                Console.WriteLine("Toplam bakiyeniz: " + tutar);

                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();

                                while (devam_mi != "1" && devam_mi != "0")
                                {
                                    Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                    Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                    devam_mi = Console.ReadLine();
                                }
                                if (devam_mi == "0")
                                {
                                    break;
                                }
                                else if (devam_mi == "1")
                                {
                                    break;
                                }
                            }
                            else if (verilecek_saat == alinacak_saat)
                            {
                                Console.WriteLine("Araçlarımız en az 1 saat kiralanabilir.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Teslim alınacak saat teslim edilecek saatten büyük olamaz.\nDilerseniz günlük kiralayabilirsiniz.\n");
                                Console.Write("Günlük kiralamak için-1 Çıkış-2: ");
                                gunluk_mu_saatlik_mi = Console.ReadLine();

                                while (gunluk_mu_saatlik_mi != "1" && gunluk_mu_saatlik_mi != "2")
                                {
                                    Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                    Console.Write("Günlük kiralamak için-1 Çıkış-2: ");
                                    gunluk_mu_saatlik_mi = Console.ReadLine();
                                }
                                if (gunluk_mu_saatlik_mi == "2")
                                {
                                    break;
                                }
                                else if (gunluk_mu_saatlik_mi == "1")
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else if (teslim_edilecek_gun > teslim_alinacak_gun && (Convert.ToInt32(teslim_edilecek_gun.Day - teslim_alinacak_gun.Day) < 30 && (teslim_edilecek_gun.Month - teslim_alinacak_gun.Month == 0)))
                    {
                        while (true)
                        {
                            int kullanilacak_gun;
                            float tutar = 0;

                            TimeSpan ts = teslim_edilecek_gun - teslim_alinacak_gun;
                            kullanilacak_gun = ts.Days;
                            Console.WriteLine("Kiralanacak Gün: " + kullanilacak_gun);
                            tutar = kullanilacak_gun * 1500;
                            Console.WriteLine("Toplam bakiyeniz: " + tutar);

                            Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                            devam_mi = Console.ReadLine();

                            while (devam_mi != "1" && devam_mi != "0")
                            {
                                Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();
                            }
                            if (devam_mi == "0")
                            {
                                break;
                            }
                            else if (devam_mi == "1")
                            {
                                break;
                            }
                        }
                    }
                    else if (teslim_edilecek_gun > teslim_alinacak_gun && Convert.ToInt32(teslim_edilecek_gun.Month - teslim_alinacak_gun.Month) != 0)
                    {
                        while (true)
                        {
                            int kullanilacak_ay;
                            float tutar = 0;

                            TimeSpan ts = teslim_edilecek_gun - teslim_alinacak_gun;
                            kullanilacak_ay = ts.Days;
                            Console.WriteLine("Kiralanacak Gün: " + kullanilacak_ay);
                            tutar = kullanilacak_ay * 40000;
                            Console.WriteLine("Toplam bakiyeniz: " + tutar);

                            Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                            devam_mi = Console.ReadLine();

                            while (devam_mi != "1" && devam_mi != "0")
                            {
                                Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();
                            }
                            if (devam_mi == "0")
                            {
                                break;
                            }
                            else if (devam_mi == "1")
                            {
                                break;
                            }
                        }
                    }
                }
                else if (arac_secimi == "3")
                {
                    Console.WriteLine("Renault Fiyat Listesi\n\tSaatlik : 30TL Günlük : 650TL Aylık : 18.000TL\n");
                    DateTime teslim_alinacak_gun;
                    Console.Write("Teslim alınacak günü (gün.ay.yıl) olarak giriniz: ");
                    teslim_alinacak_gun = Convert.ToDateTime(Console.ReadLine());

                    DateTime teslim_edilecek_gun;
                    Console.Write("Teslim edilecek günü (gün.ay.yıl) olarak giriniz: ");
                    teslim_edilecek_gun = Convert.ToDateTime(Console.ReadLine());

                    if (teslim_alinacak_gun == teslim_edilecek_gun)
                    {
                        while (true)
                        {
                            float alinacak_saat, verilecek_saat;
                            Console.Write("Aracı teslim alacağınız saat: ");
                            alinacak_saat = Convert.ToSingle(Console.ReadLine());
                            Console.Write("Aracı teslim edeceğiniz saat: ");
                            verilecek_saat = Convert.ToSingle(Console.ReadLine());

                            if (verilecek_saat > alinacak_saat)
                            {
                                float kullanilacak_saat;
                                float tutar = 0;
                                kullanilacak_saat = verilecek_saat - alinacak_saat;
                                tutar = kullanilacak_saat * 30;
                                Console.WriteLine("Toplam bakiyeniz: " + tutar);

                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();

                                while (devam_mi != "1" && devam_mi != "0")
                                {
                                    Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                    Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                    devam_mi = Console.ReadLine();
                                }
                                if (devam_mi == "0")
                                {
                                    break;
                                }
                                else if (devam_mi == "1")
                                {
                                    break;
                                }
                            }
                            else if (verilecek_saat == alinacak_saat)
                            {
                                Console.WriteLine("Araçlarımız en az 1 saat kiralanabilir.");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Teslim alınacak saat teslim edilecek saatten büyük olamaz.\nDilerseniz günlük kiralayabilirsiniz.\n");
                                Console.Write("Günlük kiralamak için-1 Çıkış-2: ");
                                gunluk_mu_saatlik_mi = Console.ReadLine();

                                while (gunluk_mu_saatlik_mi != "1" && gunluk_mu_saatlik_mi != "2")
                                {
                                    Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                    Console.Write("Günlük kiralamak için-1 Çıkış-2: ");
                                    gunluk_mu_saatlik_mi = Console.ReadLine();
                                }
                                if (gunluk_mu_saatlik_mi == "2")
                                {
                                    break;
                                }
                                else if (gunluk_mu_saatlik_mi == "1")
                                {
                                    break;
                                }
                            }
                        }
                    }
                    else if (teslim_edilecek_gun > teslim_alinacak_gun && (Convert.ToInt32(teslim_edilecek_gun.Day - teslim_alinacak_gun.Day) < 30 && (teslim_edilecek_gun.Month - teslim_alinacak_gun.Month == 0)))
                    {
                        while (true)
                        {
                            int kullanilacak_gun;
                            float tutar = 0;

                            TimeSpan ts = teslim_edilecek_gun - teslim_alinacak_gun;
                            kullanilacak_gun = ts.Days;
                            Console.WriteLine("Kiralanacak Gün: " + kullanilacak_gun);
                            tutar = kullanilacak_gun * 650;
                            Console.WriteLine("Toplam bakiyeniz: " + tutar);

                            Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                            devam_mi = Console.ReadLine();

                            while (devam_mi != "1" && devam_mi != "0")
                            {
                                Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();
                            }
                            if (devam_mi == "0")
                            {
                                break;
                            }
                            else if (devam_mi == "1")
                            {
                                break;
                            }
                        }
                    }
                    else if (teslim_edilecek_gun > teslim_alinacak_gun && Convert.ToInt32(teslim_edilecek_gun.Month - teslim_alinacak_gun.Month) != 0)
                    {
                        while (true)
                        {
                            int kullanilacak_ay;
                            float tutar = 0;

                            TimeSpan ts = teslim_edilecek_gun - teslim_alinacak_gun;
                            kullanilacak_ay = ts.Days;
                            Console.WriteLine("Kiralanacak Gün: " + kullanilacak_ay);
                            tutar = kullanilacak_ay * 18000;
                            Console.WriteLine("Toplam bakiyeniz: " + tutar);

                            Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                            devam_mi = Console.ReadLine();

                            while (devam_mi != "1" && devam_mi != "0")
                            {
                                Console.WriteLine("Hatalı kodlama\nTekrar giriş yapınız.\n");
                                Console.Write("Başka bir arzunuz var mı?(Varsa-1 Yoksa-0)\n\tSeçim: ");
                                devam_mi = Console.ReadLine();
                            }
                            if (devam_mi == "0")
                            {
                                break;
                            }
                            else if (devam_mi == "1")
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı kodlama\nTekrar deneyiniz\n");
                    continue;
                }
            }
            if (gunluk_mu_saatlik_mi == "2")
            {
                Console.WriteLine("Yine bekleriz...");
            }
            else if (devam_mi == "0")
            {
                Console.WriteLine("Yine bekleriz...");
            }
            Console.ReadLine();
        }
    }
}