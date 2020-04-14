using System;

namespace ResponsiPemrograman2697
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek karyawan1

            header();

            Karyawan karyawan1 = new Karyawan("190302123", "Paijo", -90000000);
            Console.Write("1. ");
            karyawan1.CetakGaji();

            //membuat objek Karyawan2
            Karyawan karyawan2 = new Karyawan("190302124", "Jono", 2000000);
            Console.Write("2. ");
            karyawan2.CetakGaji();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Asyique ada kenaikan gaji 10%");
            Console.WriteLine();
            header();
            Console.Write("1. ");
            karyawan1.CetakKenaikan();
            Console.Write("2. ");
            karyawan2.CetakKenaikan();

        }


       static void header()
        {
            Console.WriteLine("No NIK/Nama                 Gaji");
            Console.WriteLine("--------------------------------");
           
        }
       
    }
    
}
