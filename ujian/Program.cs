using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ujian
{
    class program
    {
        // Deklarasi Array Int Dengan Ukuran 47
        private int[] a = new int[47];

        //Deklarasi Variabel Int Untuk Menyimoan Banyaknya Data Pada Array
        private int alwan;

        //Fungsi / Method Untuk Menerima Masukan
        public void read()
        {
            //Menerima Angka Untuk Menentukan Banyaknya Data Yang Disimpan Pada Array
            while (true)
            {
                Console.Write("Masukkan Banyaknya Elemen Pada Array:");
                string s = Console.ReadLine();
                alwan = Int32.Parse(s);
                if (alwan <= 47)
                    break;
                else
                    Console.WriteLine("\nArray Dapat Mempunyai Maksimal 47 Elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("-----------------------");

            // Pengguna Memasukkan Elemen Pada Array
            for (int i = 0; i < alwan; i++)
            {
                Console.Write("<" + (i + 0) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // Menampilkan Array Yang Tersusun
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elemen Array Yang Telah Tersusun");
            Console.WriteLine("--------------------------------");
            for (int al = 0; al < alwan; al++)
            {
                Console.WriteLine(a[al]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < alwan; i++) //For n - 1 passes
            {
                // Pada pass i, Bandingkan n - i Elemen Pertama Dengan Elemen Selanjutnya
                for (int al = 0 ; al < alwan - i; al++)
                {
                    if (a[al] > a[al + 1]) // Jika Elemen Tidak Dalam Urutan Yang Benar
                    {
                        // Tukar Elemen
                        int temp;
                        temp = a[al];
                        a[al] = a[al + 1];
                        a[al + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating The Object Of The BubbleSort Class
            program mylist = new program();

            // Pemanggilan Fungsi Untuk Menerima Elemen Array
            mylist.read();
            // Pemanggilan Fungsi Untuk Mengurutkan Array
            mylist.BubbleSortArray();
            //Pemanggilan Fungsi Untuk Menampilkan Array Yang Tersusun
            mylist.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}
