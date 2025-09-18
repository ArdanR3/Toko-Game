using System;

public class GameFisik : ProdukGame
{
    public double BeratGr { get; private set; }

    public GameFisik(string judul, double harga, double beratGr) : base(judul, harga)
    {
        BeratGr = beratGr;
    }

    public override void TampilkanDetail()
    {
        Console.WriteLine($"[FISIK] {Judul} (Berat: {BeratGr} gr) - Rp{Harga:N0}");
    }
}