using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System;

namespace Latihan3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("masukan angka, 1-10");
            int[] nilai = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //string tulisan = "masukan karakter" ;
            Array.Sort(nilai);

            for (int i = 0; i < nilai.Length;)
            {
                string[] hari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };
                int days = Convert.ToInt32(Console.ReadLine());

                if (days == 1)
                {
                    Console.WriteLine(hari[0]);
                }
                else if (days == 2)
                {
                    Console.WriteLine(hari[1]);
                }
                else if (days == 3)
                {
                    Console.WriteLine(hari[2]);
                }
                else if (days == 4)
                {
                    Console.WriteLine(hari[3]);
                }
                else if (days == 5)
                {
                    Console.WriteLine(hari[4]);
                }
                else if (days == 6)
                {
                    Console.WriteLine(hari[5]);
                }
                else if (days == 7)
                {
                    Console.WriteLine(hari[6]);
                }
                else
                {
                    Console.WriteLine("Tidak ditemukan");
                }

                Console.WriteLine("masukan karakter");
                
            }
            return;

        }
    }
}
