using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace halOtomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = { "Elma", "Armut", "Portakal" };
            string[] sebzeler = { "Domates", "Biber", "Patlıcan" };
            string[] kmeyve = new string[3];
            string[] ksebze = new string[3];
            int[] meyvekg = new int[3];
            int[] sebzekg = new int[3];

            while (true)
            {
            BASADON:
                Console.WriteLine("Hoş geldiniz.\n1 Hal\n2 Manav");
                string anasecim = Console.ReadLine();

                if (anasecim == "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Talebiniz?\n1 Meyve\n2 Sebze\n3 Çıkış");
                        string kategorisecim = Console.ReadLine();

                        if (kategorisecim == "1")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Almak istediğiniz ürünü yazınız.");
                                for (int i = 0; i < meyveler.Length; i++)
                                { Console.WriteLine("{0} {1}", (i + 1), meyveler[i]); }
                                int secim = Convert.ToInt32(Console.ReadLine());

                                if (secim > meyveler.Length)
                                {
                                    Console.WriteLine("Lütfen seçiminizi listedeki ürünlerden yapın.");
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Kaç kg almak istiyorsunuz?");
                                    int kgsecim = Convert.ToInt32(Console.ReadLine());
                                    Array.Copy(meyveler, (secim - 1), kmeyve, (secim - 1), 1);
                                    meyvekg[secim - 1] += kgsecim;


                                    Console.Clear();
                                    Console.WriteLine("Başka bir şey eklemek ister misiniz? E / H");
                                    string istek = Console.ReadLine().ToUpper();


                                    if (istek == "E")
                                    {

                                    }
                                    else if (istek == "H")
                                    {
                                        goto BASADON;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş!!! Lütfen E / H dışında bir değer girmeyiniz.");
                                    }
                                }
                            }
                        }
                        else if (kategorisecim == "2")
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Almak istediğiniz ürünü yazınız.");
                                for (int i = 0; i < sebzeler.Length; i++)
                                { Console.WriteLine("{0} {1}", (i + 1), sebzeler[i]); }
                                int secim = Convert.ToInt32(Console.ReadLine());

                                if (secim > sebzeler.Length)
                                {
                                    Console.WriteLine("Lütfen seçiminizi listedeki ürünlerden yapın.");
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Kaç kg almak istiyorsunuz?");
                                    int kgsecim = Convert.ToInt32(Console.ReadLine());
                                    Array.Copy(sebzeler, (secim - 1), ksebze, (secim - 1), 1);
                                    sebzekg[secim - 1] += kgsecim;


                                    Console.Clear();
                                    Console.WriteLine("Başka bir şey eklemek ister misiniz? E / H");
                                    string istek = Console.ReadLine().ToUpper();


                                    if (istek == "E")
                                    {

                                    }
                                    else if (istek == "H")
                                    {
                                        goto BASADON;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş!!! Lütfen E / H dışında bir değer girmeyiniz.");
                                    }
                                }
                            }
                        }
                        else if (kategorisecim == "3")
                        {
                            Environment.Exit(0); 
                        }
                        else { Console.WriteLine("Hatalı Giriş!"); }
                        Console.ReadLine();
                    }
                }
                else if (anasecim == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Talebiniz?\n1 Meyve\n2 Sebze\n3 Çıkış");
                    string kategorisecim = Console.ReadLine();

                    if (kategorisecim == "1")
                    {
                        while (true)
                        {
                        MANAV:
                            Console.Clear();
                            Console.WriteLine("Almak istediğiniz ürünü seçiniz.");
                            for (int i = 0; i < kmeyve.Length; i++)
                            { Console.WriteLine("{0} {1} ({2} kg)", (i + 1), kmeyve[i], meyvekg[i]); }
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim > meyveler.Length)
                            {
                                Console.WriteLine("Lütfen seçiminizi listedeki ürünlerden yapın.");
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Kaç kg almak istiyorsunuz?");
                                int kgsecim = Convert.ToInt32(Console.ReadLine());


                                if (kgsecim > meyvekg[secim - 1])
                                {
                                    Console.Clear();
                                    Console.WriteLine("Yeterli Stok Bulunmamakta...");
                                }

                                else if (kgsecim <= meyvekg[secim - 1])
                                {
                                    meyvekg[secim - 1] -= kgsecim;
                                    if ((meyvekg[secim - 1]) <= 0)
                                    {
                                        Array.Clear(kmeyve, (secim - 1), 1);
                                    }

                                    Console.Clear();
                                    Console.WriteLine("Satın Alım Başarılı.");


                                    Console.Clear();
                                    Console.WriteLine("Başka bir şey almak ister misiniz? E / H");
                                    string istek = Console.ReadLine().ToUpper();


                                    if (istek == "E")
                                    {
                                        goto MANAV;
                                    }
                                    else if (istek == "H")
                                    {
                                        goto BASADON;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş!!! Lütfen E / H dışında bir değer girmeyiniz.");
                                    }
                                }
                            }
                        }
                    }
                    else if (kategorisecim == "2")
                    {
                        while (true)
                        {
                        MANAV:
                            Console.Clear();
                            Console.WriteLine("Almak istediğiniz ürünü seçiniz.");
                            for (int i = 0; i < ksebze.Length; i++)
                            { Console.WriteLine("{0} {1} ({2} kg)", (i + 1), ksebze[i], sebzekg[i]); }
                            int secim = Convert.ToInt32(Console.ReadLine());

                            if (secim > sebzeler.Length)
                            {
                                Console.WriteLine("Lütfen seçiminizi listedeki ürünlerden yapın.");
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Kaç kg almak istiyorsunuz?");
                                int kgsecim = Convert.ToInt32(Console.ReadLine());


                                if (kgsecim > sebzekg[secim - 1])
                                {
                                    Console.Clear();
                                    Console.WriteLine("Yeterli Stok Bulunmamakta...");
                                }

                                else if (kgsecim <= sebzekg[secim - 1])
                                {
                                    sebzekg[secim - 1] -= kgsecim;

                                    if ((sebzekg[secim - 1]) <= 0)
                                    {
                                        Array.Clear(ksebze, (secim - 1), 1);
                                    }

                                    Console.Clear();
                                    Console.WriteLine("Satın Alım Başarılı.");


                                    Console.Clear();
                                    Console.WriteLine("Başka bir şey almak ister misiniz? E / H");
                                    string istek = Console.ReadLine().ToUpper();


                                    if (istek == "E")
                                    {
                                        goto MANAV;
                                    }
                                    else if (istek == "H")
                                    {
                                        goto BASADON;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Giriş!!! Lütfen E / H dışında bir değer girmeyiniz.");
                                    }
                                }
                            }
                        }
                    }
                    else if (kategorisecim == "3")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Giriş!!!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı Giriş!!! Lütfen 1 - 2 değerlerinden birini girin.");
                }
            }
        }
    }
}
