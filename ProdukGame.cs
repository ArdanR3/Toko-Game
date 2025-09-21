public abstract class ProdukGame
{
    public string Judul { get; private set; }
    public double Harga { get; private set; }

    public ProdukGame(string judul, double harga)
    {
        Judul = judul;
        Harga = harga;
    }

    public abstract void TampilkanDetail();
}