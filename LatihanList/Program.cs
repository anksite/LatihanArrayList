using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanList
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "123";
            mhs1.NamaMhs = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMhs = "Wely";

            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Jhono";

            List<Mahasiswa> list = new List<Mahasiswa>();
            list.Add(mhs1);
            list.Add(mhs2);

            foreach (Mahasiswa mhs in list) {
                Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMhs);
            }            

            Console.ReadKey();
        }

        void latihan1() {
            List<string> listMhs = new List<string>();

            listMhs.Add("erick");
            listMhs.Add("wely");
            listMhs.Add("rully");

            string mhs = listMhs[1];
            Console.WriteLine(mhs);
            Console.WriteLine();

            foreach (string nama in listMhs)
            {
                Console.WriteLine(nama);
            }
            Console.ReadKey();
        }
    }
}
