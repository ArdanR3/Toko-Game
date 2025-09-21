using System;
using System.Collections.Generic;
using System.Linq;

public class KeranjangBelanja
{
    private List<ProdukGame> _items = new List<ProdukGame>();

    public void TambahProduk(ProdukGame produk)
    {
        _items.Add(produk);
        Console.WriteLine($"-> Menambahkan 1 '{produk.Judul}' ke keranjang.");
    }

    public void TambahProduk(ProdukGame produk, int jumlah)
    {
        for (int i = 0; i < jumlah; i++)
        {
            _items.Add(produk);
        }
        Console.WriteLine($"-> Menambahkan {jumlah} '{produk.Judul}' ke keranjang.");
    }

    public void TampilkanIsiKeranjang()
    {
        Console.WriteLine("\n--- Isi Keranjang ---");
        if (_items.Count == 0)
        {
            Console.WriteLine("Keranjang masih kosong.");
        }
        else
        {
            foreach (var item in _items)
            {
                item.TampilkanDetail();
            }
        }

        double total = _items.Sum(item => item.Harga);
        Console.WriteLine($"---------------------\nTotal Belanja: Rp{total:N0}\n");
    }
}