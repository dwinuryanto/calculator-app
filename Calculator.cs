
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main(string[] args)
        {


            Console.Write("Pilih menu Calculator: \n");
            Console.WriteLine();

            Console.Write("1. penjumlahan\n");
            Console.Write("2. pengurangan\n");
            Console.Write("3. perkalian\n");
            Console.Write("4. pembagian\n");

            Console.WriteLine();

            Console.Write(" masukan nomor menu {1-4}: ");
            int z = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            if (z == 1)
            {
                Console.Write("masukan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("hasil penjumlahan " + a + " + " + b + " = " + penambahan(a, b));
            }

            else if (z == 2)
            {
                Console.Write("masukan nilai x = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai y = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("hasil pengurangan: " + a + " - " + b + " = " + pengurangan(a, b));
            }

            else if (z == 3)
            {
                Console.Write("masukan nilai x = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai y = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("hasil perkalian: " + a + " * " + b + " = " + perkalian(a, b));
            }

            else if (z == 4)
            {
                Console.Write(" masukan nilai x = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("masukan nilai y = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("hasil pembagian: " + a + " / " + b + " = " + pembagian(a, b));
            }

            else
            {
                Console.Write("pilihan anda tidak ada");
            }

            Console.WriteLine();
            Console.WriteLine("\ntekan apa saja untuk keluar");
            Console.ReadKey();
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
