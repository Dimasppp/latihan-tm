// See https://aka.ms/new-console-template for more informationusing System;

using System.IO.Pipes;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        class Person
        {
            public string Name;
            public string Alamat;
            public string JenisKelamin;
            public string Hoby;
            public string TglLahir;
            public int JumlahKendaraan;

            public Person (string Name, string Alamat, string JenisKelamin, string Hoby, string TglLahir, int JumlahKendaraan)
            {
                this.Name = Name;
                this.Alamat = Alamat;
                this.JenisKelamin = JenisKelamin;
                this.Hoby = Hoby;
                this.TglLahir = TglLahir;
                this.JumlahKendaraan = JumlahKendaraan;
            }
        }
        public static void Main(string[] args)
        {
            Person Raisa = new Person("Raisa", "Jakarta", "P", "Membaca", "23 Mei 1998", 3);
            Console.WriteLine("Nama Lengkap : " + Raisa.Name);
            Console.WriteLine("Alamat : " + Raisa.Alamat);
            Console.WriteLine("Jenis Kelamin : " + Raisa.JenisKelamin);
            Console.WriteLine("Hobby : " + Raisa.Hoby);
            Console.WriteLine("Tanggal Lahir : " + Raisa.TglLahir);
            Console.WriteLine("Jumlah Kendaraan : " + Raisa.JumlahKendaraan);
        }

        
    }
}
