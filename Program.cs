﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> listKaryawan = new List<Karyawan>();

            void TampilanKaryawan()
            {
                int noUrut = 1;
                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. NIK: {1}, name: {2}, Gaji: {3}, {4}", noUrut, karyawan.NIK, karyawan.name, karyawan.Gaji(), karyawan.JK);
                    noUrut++;
                }
            }
			
            void tambahKaryawanTetap(string name, string nik, string jk, double gajibulanan)
            {
                listKaryawan.Add(new KaryawanTetap { name = name, NIK = nik, GajiBulanan = gajibulanan, JK = jk });
            }

            void tambahKaryawanHarian(string name, string nik, string jk, int jumlahjamkerja, int upah)
            {
                listKaryawan.Add(new KaryawanHarian { name = name, NIK = nik, JK = jk, JumlahJamKerja = jumlahjamkerja, UpahPerJam = upah });
            }

            void tambahSales(string name, string nik, string jk, int jumlahpenjualan, int komisi)
            {
                listKaryawan.Add(new Sales { name = name, NIK = nik, JK = jk, JumlahPenjualan = jumlahpenjualan, Komisi = komisi });
            }

            void hapusKaryawan()
            {
                int no = 1;
                int jumlah_karyawan = 0;
                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. Nik: {1}", no, karyawan.NIK);
                    no++;
                    jumlah_karyawan += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlah_karyawan);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listKaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool keluar = false;
            while (keluar == false)
            {
                Console.Title = "Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("Pilih Menu :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data");
                Console.WriteLine("2. Hapus Data");
                Console.WriteLine("3. Tampilkan Data");
                Console.WriteLine("4. Keluar");
                Console.WriteLine();
                Console.Write("Pilihan [1..4] = ");
                int menu = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                if (menu < 1)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu > 4)
                {
                    Console.WriteLine("Maaf, Menu Yang Anda Pilih Tidak Tersedia");
                }
                else if (menu == 1)
                {
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                    int jk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (jk == 1)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("name = ");
                        string name = Console.ReadLine();
                        Console.Write("Gaji Bulanan = ");
                        int gb = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Tetap";

                        tambahKaryawanTetap(jenis, nik, name, gb);
                    }
                    else if (jk == 2)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("name = ");
                        string name = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja = ");
                        int jamkerja = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam = ");
                        int upah = int.Parse(Console.ReadLine());
                        string jenis = "Karyawan Harian";

                        tambahKaryawanHarian(jenis, nik, name, jamkerja, upah);
                    }
                    else if (jk == 3)
                    {

                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("name = ");
                        string name = Console.ReadLine();
                        Console.Write("Jumlah Jual = ");
                        int jumlahjual = int.Parse(Console.ReadLine());
                        Console.Write("Komisi = ");
                        int komisi = int.Parse(Console.ReadLine());
                        string jenis = "Sales";

                        tambahSales(jenis, nik, name, jumlahjual, komisi);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah mohon diulang");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");


                }
                else if (menu == 2)
                {
                    hapusKaryawan();
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Data Karyawan");
                    Console.WriteLine();
                    TampilanKaryawan();
                    Console.WriteLine("\nTekan Enter Untuk Kembali");
                }
                else if (menu == 4)
                {
                    keluar = true;
                }
                Console.ReadLine();
            }
        }
    }
}
