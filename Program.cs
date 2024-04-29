using System;
using System.Collections.Generic;

namespace BasicCRUDApp
{
    class Program
    {

        static List<string> data = new List<string>();
        static void Main(string[] args)
        {

            bool contExc = true;
            while (contExc)
            {
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
                    Viewdata();
                }
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

        static void Viewdata()
        {
            Console.WriteLine("Verilerin Listesi");
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {data[i]}");
            }
        }
        static void AddItem()
        {
            Console.WriteLine("Eklenecek veriyi yazınız:");
            string newItem = Console.ReadLine();
            data.Add(newItem);
            Console.WriteLine("Veri Başarıyla eklendi.");
        }

        static void UpdateItem()
        {
            Viewdata();
            Console.WriteLine("Güncellenecek Verinin Numarasını Giriniz:");
            int idx = int.Parse(Console.ReadLine());
            if (idx >= 1 && idx <= data.Count)
            {
                Console.WriteLine($"Veri {data[idx - 1]}'in yeni değerini giriniz:");
                string newValue = Console.ReadLine();
                data[idx - 1] = newValue;
                Console.WriteLine("Veri Başarıyla Güncellendi.");
            }
            else
            {
                Console.WriteLine("Yanlış Indeks Numarası Girdiniz. Tekrar Deneyin.");
            }
        }

        static void DeleteItem()
        {
            Viewdata();
            Console.WriteLine("Silmek İstediğiniz Verinin İndeks Numarasını Giriniz.");
            int idx = int.Parse(Console.ReadLine());
            if (idx >= 1 && idx <= data.Count)
            {
                data.RemoveAt(idx - 1);
                Console.WriteLine("Veri Başarıyla Silindi.");
            }
            else
            {
                Console.WriteLine("Geçersiz Indeks Numarası Girdiniz. Tekrar Deneyiniz.");
            }
        }
    }
}
