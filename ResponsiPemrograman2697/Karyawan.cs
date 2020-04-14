using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemrograman2697
{
    class Karyawan
    {
             
        //contructor dengan 3 parameter
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            

            if (gajibulanan<0)
            {
                gajibulanan = 0;
            }
            else
            {
                gajibulanan = gajibulanan;
            }

            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
            
            int kenaikan = gajibulanan * 10 / 100;
            int gaji = kenaikan + gajibulanan;

            Gaji = gaji;
        }

        

        //properties
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int Gaji { get; set; }

        public void CetakGaji()
        {
           Console.WriteLine("{0} {1}       {2}", Nik, Nama, GajiBulanan);
        }

        public void CetakKenaikan()
        {
            Console.WriteLine("{0} {1}       {2}", Nik, Nama, Gaji);
        }

    }
}
