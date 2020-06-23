using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_dan_collection.ClassInduk;
using oop_dan_collection.ClassAnak;

namespace oop_dan_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Abstraction & Collection";

            //membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "1999000172";
            karyawanTetap.Nama = "Ryan Gonzalez";
            karyawanTetap.GajiBulanan = 15000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "1997000150";
            karyawanHarian.Nama = "Rikha Yolanda";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 50000;

            Sales sales = new Sales();
            sales.Nik = "1997000155";
            sales.Nama = "Samsudin Sugihartono";
            sales.JumlahPenjualan = 25;
            sales.Komisi = 200000;

            //objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
