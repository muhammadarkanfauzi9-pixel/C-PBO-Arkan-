using System;

class Program
{
    static void Main(string[] args) //method main nya ada disini
    {
        Program panggil = new Program();
        panggil.sapa("Fikri", 20);
        contoh(10000);
        Console.WriteLine(Hitung());
        Console.WriteLine(Jumlah(new int[] { 1, 2, 3, 4, 5 }));
        Cetakarray(new int[] { 10, 20, 30, 40, 50 });
        Looping.jalankanlooping();
    }
    void sapa(string nama, int umur) //pakai parameter kalau nggak ada modifier maka otomatis menjadi public akan tetapi saat memanggil harus memakai objek
    {
        Console.WriteLine("Halo teman teman namaku adalah :" + nama + " umur saya " + umur + " tahun");
    }

    static void contoh(int harga) //pakai parameter
    {
        int uang = 20000;
        int total = uang - harga;
        Console.WriteLine("saya suka mie ayam yang harganya adalah : " + harga + " Saya membayar dengan uang : " + uang + " sisa uang saya adalah : " + total);

    }

    static int Hitung()//memakai return karena tidak ada void adanya memakai int sehingga diperlukan return untuk bisa dijalankan diluar method
    {
        int a = 10;
        int b = 20;
        int nilai = a + b;
        return nilai;
    }

    static void Cetakarray(int[] angka) //method array
    {
        Console.WriteLine("Isi array adalah : ");
        foreach (int item in angka)
        {
            Console.WriteLine(item);
        }
    }

    static int Jumlah(int[] angka) //method dengan return
    {
        int jumlah = 0;
        foreach (int item in angka)
        {
            jumlah += item;
        }
        return jumlah;
    }

}

