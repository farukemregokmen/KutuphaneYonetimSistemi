using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

List<Roman> romanList = new List<Roman>();
List<CocukKitabi> cocukKitabiList = new List<CocukKitabi>();
List<Ansiklopedi> ansiklopediList = new List<Ansiklopedi>();

while (true)
{
    //Variables
    int id, sayfaSayisi;
    string? kitapAdi, yazar, yayinEvi;
    //Console menu
    Console.WriteLine("\t\tKutuphane Yonetim Sistemi\n\n");
    Console.WriteLine("1. Kitap Ekle");
    Console.WriteLine("2. Kitaplari Listele");
    Console.WriteLine("3. Kitap Kirala");
    Console.WriteLine("4. Kitap Iade Et");
    Console.Write("Islem secin: ");
    string? islem = Console.ReadLine();
    Console.Clear();
    switch (islem)
    {
        case "1":
            try {
                Console.Write("Kitap idsi: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kitap adi: ");
                kitapAdi = Console.ReadLine();
                Console.Write("Yazar adi: ");
                yazar = Console.ReadLine();
                Console.Write("Yayin evi: ");
                yayinEvi = Console.ReadLine();
                Console.Write("Sayfa sayisi: ");
                sayfaSayisi = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Gecersiz veri girisi: " + ex.Message);
                break;
            }

            // Kitap tur secimi
            Console.WriteLine("1. Roman");
            Console.WriteLine("2. Cocuk Kitabi");
            Console.WriteLine("3. Ansiklopedi");
            Console.Write("Kitap turunu secin: ");
            int tur = Convert.ToInt16(Console.ReadLine());
            switch (tur)
            {
                case 1:
                    try
                    {
                        romanList.Add(new Roman(id, kitapAdi!, yazar!, yayinEvi!, sayfaSayisi));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        cocukKitabiList.Add(new CocukKitabi(id, kitapAdi!, yazar!, yayinEvi!, sayfaSayisi));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        ansiklopediList.Add(new Ansiklopedi(id, kitapAdi!, yazar!, yayinEvi!, sayfaSayisi));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Gecersiz kitap turu secildi.");
                    break;
            }
            Console.Clear();
            break;
        case "2":
            // Kitaplari listele
            Console.WriteLine("Kitaplar listelenecek...\n");
            if (romanList.Count == 0)
            {
                Console.WriteLine("Roman listesi bos.");
            }
            else
            {
                Console.WriteLine("-----------------------------\n");
                Console.WriteLine("ROMANLAR\n");
                Console.WriteLine("-----------------------------\n");
                foreach (var roman in romanList)
                {
                    roman.KitapListele();
                    Console.WriteLine("-----------------------------");
                }
            }
            if (cocukKitabiList.Count == 0)
            {
                Console.WriteLine("Cocuk kitabi listesi bos.");
            }
            else
            {
                Console.WriteLine("-----------------------------\n");
                Console.WriteLine("COCUK KITAPLARI\n");
                Console.WriteLine("-----------------------------\n");
                foreach (var cocukKitabi in cocukKitabiList)
                {
                    cocukKitabi.KitapListele();
                    Console.WriteLine("-----------------------------");
                }
            }
            if (ansiklopediList.Count == 0)
            {
                Console.WriteLine("Ansiklopedi listesi bos.");
            }
            else
            {
                Console.WriteLine("-----------------------------\n");
                Console.WriteLine("ANSIKLOPEDILER\n");
                Console.WriteLine("-----------------------------\n");
                foreach (var ansiklopedi in ansiklopediList)
                {
                    ansiklopedi.KitapListele();
                    Console.WriteLine("-----------------------------");
                }
            }
            Console.ReadLine();
            Console.Clear();
            break;
        case "3":
            // Kitap kiralama
            Console.Write("Kiralamak istediginiz kitabın ID'sini girin: ");
            int kiralamaId = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (var roman in romanList)
            {
                if (roman.id == kiralamaId)
                {
                    roman.KitapKirala(kiralamaId);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                foreach (var cocukKitabi in cocukKitabiList)
                {
                    if (cocukKitabi.id == kiralamaId)
                    {
                        cocukKitabi.KitapKirala(kiralamaId);
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                foreach (var ansiklopedi in ansiklopediList)
                {
                    if (ansiklopedi.id == kiralamaId)
                    {
                        ansiklopedi.KitapKirala(kiralamaId);
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("Bu ID'ye sahip bir kitap bulunamadi.");
            }
            Console.Clear();
            break;
        default:
            Console.WriteLine("Gecersiz islem. Lutfen tekrar deneyin.");
            break;
    }
}