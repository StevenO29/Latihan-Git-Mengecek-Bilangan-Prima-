using System;

namespace Latihan_Git_Mengecek_Bilangan_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka yang akan dicek : ");
            int inputAngka = Convert.ToInt32(Console.ReadLine());
            int jumlahAngka = 0;
            for (int pengulanganAngka = 1; pengulanganAngka <= inputAngka; pengulanganAngka++)
            {
                int sisaAngka = inputAngka % pengulanganAngka;
                if (sisaAngka == 0)
                    jumlahAngka += 1;
                else
                    _ = jumlahAngka == 0;
            }
            if (jumlahAngka > 2)
                Console.Write($"\n{inputAngka} adalah bukan bilangan prima");
            else
                Console.Write($"\n{inputAngka} adalah bilangan prima");
        }
    }
}