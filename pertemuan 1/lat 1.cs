// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World! hai arkan fauzi");
Console.WriteLine("hai arkan fauzi");
Console.WriteLine(3+3);

int mynum = 5;
mynum = 10;
Console.WriteLine(mynum);


//belajar sendiri
double person = 19.99;
double HAKAN = 5.2;
Console.WriteLine(person + HAKAN);


//arrays 
string[] absen =  {"andi", "mela" };
//belajar lagi 

int x, y;
int z;
string nama;
x = 10;
y = 5;
z = 100;
nama = "arkan";

Console.WriteLine('z' + nama + x + y);
Console.WriteLine(x + y);
Console.WriteLine(z + (x + y));


/* if dan else 
jadi untuk if dan else berikut penjelasannya 
int usia( type data dan nama variable) = isi dari variable
if jika usia lebih dari 51 maka menampilkan usai + 50 dan string = usia bapak andi lebih  50 tahun */
int Usia = 1000;
if (Usia > 51)
{
    Console.WriteLine(Usia + 50);
    Console.Write("Usia Bapak Andi Adalah lebih dari 50 tahun");
}
else
{
    Console.WriteLine("Usia Bapak Andi 50 Tahun");
}

//Float and double
//e atau E itu adalah lambang dari pangkat 10

float number = 35e3F;
double number1 = 40E3D;
Console.WriteLine(number + number1);

//latihan diskon

int hargaumum = 10000;
string tidak = "maaf anda tidak mendapatkan diskon";
if (hargaumum > 11000)
{
    Console.WriteLine(hargaumum * 0.5);
}
else
{
    Console.WriteLine(hargaumum + "maaf anda tidak mendapatkan diskon");
}

//password dengan string

Console.WriteLine("Masukkan username mu :");
string username = Console.ReadLine();

Console.WriteLine("usernamemu adalah" + username);

//password dengan int 

Console.WriteLine("Masukkan Password");
int password = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Passwordmu adalah" + password);
Console.WriteLine("berikut adalah username dan password mu");
Console.WriteLine(username + " dan " + password);



