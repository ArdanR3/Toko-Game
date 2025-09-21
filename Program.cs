using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Selamat Datang di G-Store!");
        Console.WriteLine("==========================\n");

        // Membuat objek dari berbagai jenis game
        GameFisik eldenRingFisik = new GameFisik("Elden Ring PS5", 750000, 150);
        GameDigital eldenRingDigital = new GameDigital("Elden Ring", 699000, "Steam", 60);
        GameDigital sekiro = new GameDigital("Sekiro: Shadows Die Twice", 250000, "Steam", 25);

        // Menampilkan daftar produk
        Console.WriteLine("Daftar Game Terlaris:");
        eldenRingFisik.TampilkanDetail();
        eldenRingDigital.TampilkanDetail();
        sekiro.TampilkanDetail();

        Console.WriteLine("\n------------------------------------\n");

        // Simulasi pembelian
        Pelanggan pelanggan1 = new Pelanggan("Ardan");
        Console.WriteLine($"Pelanggan '{pelanggan1.Nama}' memulai belanja.");

        pelanggan1.Keranjang.TampilkanIsiKeranjang();

        pelanggan1.Keranjang.TambahProduk(sekiro);
        pelanggan1.Keranjang.TambahProduk(eldenRingFisik, 2);

        pelanggan1.Keranjang.TampilkanIsiKeranjang();

        Console.WriteLine("Terima kasih sudah berbelanja!");
    }
}