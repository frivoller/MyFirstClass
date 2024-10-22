using System;

namespace OkulYonetimSistemi
{
    // sinif
    public class Person
    {
        // ozellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        // constructor
        public Person(string ad, string soyad, DateTime dogumTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
        }

        // method
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
        }
    }

    // main class
    class Program
    {
        static void Main(string[] args)
        {
            // ogrenci nesneleri olusturma
            Person ogrenci1 = new Person("Melis", "Yıldız", new DateTime(2000, 11, 1));
            Person ogrenci2 = new Person("Mahir", "Tanrıverdi", new DateTime(2000, 10, 17));

            // ogretmen nesneleri olusturma
            Person ogretmen1 = new Person("Mehmet", "Aslan", new DateTime(1980, 5, 10));
            Person ogretmen2 = new Person("Emre", "Aydın", new DateTime(1985, 2, 22));

            // ogrenci bilgilerini yazdirma
            Console.WriteLine("Öğrenci Bilgileri:");
            ogrenci1.BilgileriYazdir();
            ogrenci2.BilgileriYazdir();

            // ogretmen bilgilerini yazdirma
            Console.WriteLine("\nÖğretmen Bilgileri:");
            ogretmen1.BilgileriYazdir();
            ogretmen2.BilgileriYazdir();
        }
    }
}
