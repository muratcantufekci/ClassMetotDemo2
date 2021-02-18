using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Muratcannn";
            musteri.Soyad = "Tüfekçi";
            musteri.Eposta = "abcd@hotmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Uğur";
            musteri2.Soyad = "Duman";
            musteri2.Eposta = "abcde@hotmail.com";

            Musteri[] musteriListe = new Musteri[] { musteri, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Silme(musteri);
            musteriManager.Ekle(musteri2);
            musteriManager.Silme(musteri2);
            musteriManager.Listeleme(musteriListe);

            Console.ReadKey();
        }
    }
}
