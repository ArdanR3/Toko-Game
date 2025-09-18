using System;

public class GameDigital : ProdukGame
{
    public int UkuranGB { get; private set; }
    public string Platform { get; private set; }

    public GameDigital(string judul, double harga, string platform, int ukuranGB) : base(judul, harga)
    {
        Platform = platform;
        UkuranGB = ukuranGB;
    }

    public override void TampilkanDetail()
    {
        Console.WriteLine($"[DIGITAL] {Judul} (Platform: {Platform}, Ukuran: {UkuranGB} GB) - Rp{Harga:N0}");
    }
}