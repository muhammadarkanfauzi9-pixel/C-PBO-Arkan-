// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!, Silahkan ada yang bisa dibantu? ");

string Username = Console.ReadLine();

Console.WriteLine("owwhh kamu ingin mengisi form biodata?, boleh banget isi kolom kolom berikut yaaa!!!");

Console.Write("Masukkan Biodata Anda : ");
string Nama = Console.ReadLine();
Console.Write("Masukkan Kelas Anda : ");
string Kelas = Console.ReadLine();
Console.Write("Masukkan Absen Anda : ");
int Absen = Convert.ToInt32(Console.ReadLine());
Console.Write("Masukkan Jurusan Anda : ");
string jurusan = Console.ReadLine();
Console.WriteLine("Biodata Anda adalah : " + Nama + " Kelas : " + Kelas + " Absen : " + Absen + " Jurusan : " + jurusan);
Console.WriteLine("Terima kasih karena telah mengisi form biodata mu");






// Console.WriteLine(Math.Abs(-5)); //untuk nilai absolute
// Console.WriteLine(Math.Sqrt(22));//untuk asal nilai kuadrat dari kuadrat nilai apa, contoh 16 dari nilai kuadrat 4²
// Console.WriteLine(Math.Pow(2, 3));//untuk nilai pangkat 
// Console.WriteLine(Math.Round(3.7)); //untuk menghasilkan nilai bulat yang paling dekat dari nilai desimal 
// Console.WriteLine(Math.Max(5, 10)); //nilai terbesar dari dua angka
// Console.WriteLine(Math.Min(10, 15));//nilai terkecil dari dua angka