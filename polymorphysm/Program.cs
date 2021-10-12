using System;
namespace ConsoleApplication1
{
    class Mahasiswa
    {
        public string nama;
        public string matkul;
        public void readers(string nama, string matkul)
        {
            this.nama = nama;
            this.matkul = matkul;
            Console.WriteLine("Nama Saya " + nama);
            Console.WriteLine("Mata kuliah favorit saya adalah " + matkul);
        }
    }
    class mahasiswa : Mahasiswa
    {
        public mahasiswa()
        {
            Console.WriteLine("mahasiswa");
        }
    }
    class Sudo
    {
        static void Main(string[] args)
        {
            mahasiswa g = new mahasiswa();
            g.readers("Maula", "PBO");
            Console.ReadLine();
        }
    }
}