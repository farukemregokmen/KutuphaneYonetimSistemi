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
            Console.Write("Kitap idsi: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kitap adi: ");
            string? kitapAdi = Console.ReadLine();
            Console.Write("Yazar adi: ");
            string? yazar = Console.ReadLine();
            Console.Write("Yayin evi: ");
            string? yayinEvi = Console.ReadLine();
            Console.Write("Sayfa sayisi: ");
            int sayfaSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
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
                Console.WriteLine("Liste bos.");
            }
            else
            {
                foreach (var roman in romanList)
                {
                    roman.KitapListele();
                    Console.WriteLine("-----------------------------");
                }
            }
            break;
    }
}