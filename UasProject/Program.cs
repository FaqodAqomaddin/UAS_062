using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UasProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Barang> daftarBarang = new List<Barang>();
            int pilihan;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Masukkan data Barang");
                Console.WriteLine("2. Tampilkan data Barang");
                Console.WriteLine("3. Cari data Barang");
                Console.WriteLine("4. Keluar");
                Console.WriteLine("-----------------------------------");
                Console.Write("Pilihan: ");
                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                        Barang brg = new Barang();
                        Console.Write("Masukkan IdBarang: ");
                        brg.IdBarang = Console.ReadLine();
                        Console.Write("Masukkan Nama Barang: ");
                        brg.NamaBarang = Console.ReadLine();
                        Console.Write("Masukkan Jenis Barang: ");
                        brg.JenisBarang = Console.ReadLine();
                        Console.Write("Masukkan Harga Barang: ");
                        brg.HargaBarang = Console.ReadLine();
                        daftarBarang.Add(brg);
                        break;
                    case 2:
                        Console.WriteLine("Data Barang:");
                        foreach (Barang b in daftarBarang)
                        {
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("1. Id Barang: " + b.IdBarang);
                            Console.WriteLine("2. Nama Barang: " + b.NamaBarang);
                            Console.WriteLine("3. Jenis Barang: " + b.JenisBarang);
                            Console.WriteLine("4. Harga Barang: " + b.HargaBarang);
                            Console.WriteLine("-----------------------------------");
                        }
                        break;
                    case 3:
                        Console.Write("Masukkan data yang ingin dicari: ");
                        string cari = Console.ReadLine();
                        bool ketemu = false;
                        foreach (Barang b in daftarBarang)
                        {
                            if (b.JenisBarang == cari)
                            {
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine("Data ditemukan:");
                                Console.WriteLine("IdBarang: " + b.IdBarang);
                                Console.WriteLine("Nama Barang: " + b.NamaBarang);
                                Console.WriteLine("Jenis Barang: " + b.JenisBarang);
                                Console.WriteLine("Harga Barang: " + b.HargaBarang);
                                Console.WriteLine("-----------------------------------");
                                ketemu = true;
                            }
                        }
                        if (!ketemu)
                        {
                            Console.WriteLine("Data tidak ditemukan.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Terima kasih");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid, silakan masukkan pilihan yang benar.");
                        break;
                }
            } while (pilihan != 4);
        }
    }
    class Barang
    {
        public string IdBarang { get; set; }
        public string NamaBarang { get; set; }
        public string JenisBarang { get; set; }
        public string HargaBarang { get; set; }
    }


}





/*Berdasarkan studi kasus diatas, algoritma apa saja yang anda gunakan? Jelaskan mengapa anda memilih algoritma tersebut
 *single linked list karena lebih efisien dalam mengurutkan data dan saya lebih memahami konsep single linked list ketimbang double linked list */

/*Sebutkan dan Jelaskan perbedaan dari array dan linked list dan kapan harus menggunakan tipe data tersebut ?
 * Array dan linked list adalah tipe data yang sama yaitu sama-sama menggunakan struktur data jenis linier yang membedakan linked list dengan array adalah 
 * array tidak mempunyai pointer atau penghubung satu data dengan data yang lain */

/*Algoritma Queue merupakan struktur data dimana satu data dapat ditambakan diakhir disebut .... dan data dihapus dari yang paling terkahir disebut ....?
 * Circural queue
 * Double-Ended queue */

/*Tentukan sibling dari tree diatas ?
 * 60 adalah Akar
 * 41 dan 74 adalah Batang
 * 16, 53 dan 65 adalah Dahan
 * 25, 46, 55, 63 dan 70 adalah Ranting
 * 42, 62 dan 64 adalah Daun atau leaf
 */

/*Bagaimana cara membaca struktur pohon di atas ?
 * Inorder */