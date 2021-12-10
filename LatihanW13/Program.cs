using System;

namespace LatihanW13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Silahkan input kalimat : ");
            string kalimat = Console.ReadLine();
            int jumlahkata = kalimat.Split(' ').Length;
            if (jumlahkata < 3)
            {
                Console.WriteLine("\nKATA PADA KALIMAT KURANG PANJANG!\n");
                Console.Write("Silahkan input kalimat : ");
                kalimat = Console.ReadLine();
            }
            Console.Write("Silahkan input kata : ");
            string kata = Console.ReadLine();
            int jumlahhuruf = kata.Length;
            if (jumlahhuruf < 2 )
            {
                Console.WriteLine("\nHURUF PADA KATA KURANG PANJANG!\n");
                Console.Write("Silahkan input kata : ");
                kata = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"KALIMAT : {kalimat.ToUpper()}");
            Console.WriteLine($"KATA : {kata.ToUpper()}\n");

            Console.WriteLine("STATISTIK HURUF : ");
            Console.Write($"STATISTIK KATA : ");
            int JUMLAHHURUF = kalimat.Length - (jumlahkata - 1);
            Console.WriteLine($"JUMLAH HURUF : {JUMLAHHURUF}");









        }
    }
}
