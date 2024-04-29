using System;
using System.Collections.Generic;

namespace BasicCRUDApp
{
    class Program
    {

        static List<string> items = new List<string>();
        static void Main(string[] args)
        {

            bool contExc = true;
            while (contExc)
            {
                Console.WriteLine("İşlem Seçiniz");
                Console.WriteLine("1. Veri Ekle");
                Console.WriteLine("2. Verileri Görüntüle");
                Console.WriteLine("3. Bir Veri Güncelle");
                Console.WriteLine("4. Bit Veri Sil");
                Console.WriteLine("5. Çık");

                int operation = int.Parse(Console.ReadLine());
                if (operation == 1)
                {
                    AddItem();
                }
                else if (operation == 2)
                {
                    ViewItems();
                }<><    <   <   <
                else if (operation == 3)
                {
                    UpdateItem();
                }
                else if (operation == 4)
                {
                    DeleteItem();
                }
                else if (operation == 5)
                {
                    contExc = false;
                }
                else
                {
                    Console.WriteLine("Yanlış Tuşlama");
                }
            }
        }

        static void ViewItems()
        {
            Console.WriteLine("Verilerin Listesi");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
        }
        static void AddItem()
        {
            Console.WriteLine("Eklenecek veriyi yazınız:");
            string newItem = Console.ReadLine();
            items.Add(newItem);
            Console.WriteLine("Veri Başarıyla eklendi.");
        }

        static void UpdateItem()
        {
            ViewItems();
            Console.WriteLine("Güncellenecek Verinin Index'ini Giriniz:");
            int index = int.Parse(Console.ReadLine());
            if (index >= 1 && index <= items.Count)
            {
                Console.WriteLine($"Veri {index}'in yeni değerini giriniz:");
                string newValue = Console.ReadLine();
                items[index - 1] = newValue;
                Console.WriteLine("Veri Başarıyla Güncellendi.");
            }
            else
            {
                Console.WriteLine("Yanlış Indeks Numarası Girdiniz. Tekrar Deneyin.");
            }
        }

        static void DeleteItem()
        {
            ViewItems();
            Console.WriteLine("Silmek İstediğiniz Verinin İndeks Numarasını Giriniz.");
            int index = int.Parse(Console.ReadLine());
            if (index >= 1 && index <= items.Count)
            {
                items.RemoveAt(index - 1);
                Console.WriteLine("Veri Başarıyla Silindi.");
            }
            else
            {
                Console.WriteLine("Geçersiz Indeks Numarası Girdiniz. Tekrar Deneyiniz.");
            }
        }
    }
}
