namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir  Kitap kategorisi Seciniz");
            string KitapKategori1 = Console.ReadLine();
            KitapKategori kitapKategori = (KitapKategori)Enum.Parse(typeof(KitapKategori),KitapKategori1);
            switch (kitapKategori)
            {
                case KitapKategori.BilimKurgu:
                    Console.WriteLine("Bilim kurgu A reyonundadır.");
                    break;
                case KitapKategori.DunyaKlasikleri: Console.WriteLine("Dünya klasikleri B reyonundadır."); break;
                case KitapKategori.Psikoloji: Console.WriteLine("Psikoloji C reyonundadır."); break;
                case KitapKategori.Aksiyon: Console.WriteLine("Aksiyon D reyonundadır."); break;
                case KitapKategori.Macera: Console.WriteLine("Macera Kasa Arkasındadır."); break;
                default: Console.WriteLine("yanlış bir kategori"); break;

            }

        }
    }
}
