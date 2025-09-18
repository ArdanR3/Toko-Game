public class Pelanggan
{
    public string Nama { get; private set; }
    public KeranjangBelanja Keranjang { get; private set; }

    public Pelanggan(string nama)
    {
        Nama = nama;
        Keranjang = new KeranjangBelanja();
    }
}