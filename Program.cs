﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar\n");
        }

        static void TambahProduk()
        {
            Console.Clear();
			Console.WriteLine("Tambahkan Data Produk\n");
			Produk produk = new Produk();
			Console.Write("Kode Produk : ");
            produk.Kode = Console.ReadLine();
			Console.Write("Nama Produk : ");
			produk.Nama = Console.ReadLine();
			Console.Write("Harga Beli : ");
			produk.HargaBeli = Console.ReadLine();
			Console.Write("Harga Jual : ");
			produk.HargaJual = Console.ReadLine();

			daftarProduk.Add(produk);

			Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();
			
			Console.WriteLine("Hapus Data Produk\n");
			Console.Write("Kode Produk : ");
			string kode = Console.ReadLine();

            Produk delPro = daftarProduk.SingleOrDefault(f => f.Kode == kode);
            if (daftarProduk.Contains(delPro) == true)
            {
                daftarProduk.Remove(delPro);
                Console.WriteLine("Data Produk Berhasil di hapus");
            }
            else
            {
                Console.WriteLine("Kode produk tidak ditemukan");
            }
           

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
			Console.WriteLine("Data Produk\n");
			int noUrut = 1;
			foreach (Produk produk in daftarProduk)
			{
				Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noUrut, produk.Kode, produk.Nama, produk.HargaBeli, produk.HargaJual);
                noUrut++;
			}
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
