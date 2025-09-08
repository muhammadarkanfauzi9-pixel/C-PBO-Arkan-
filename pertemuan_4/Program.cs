//inheritance 

using System;

namespace pertemuan_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();//untuk membuat objed dari class car
            myCar.honk();//memanggil method honk dari class vehicle yang telah diwarisi ke class car
            Console.Write("Brand dari mobilku adalah : " + myCar.brand +  " | model dari mobilku adalah "  +  myCar.modelName);/*memanggil field brand dari class vehicle 
            yang telah diwarisi ke class car dan memanggil field modelName dari class car dengan mencantumkan
            objek yang telah dibuat*/
        }
    }
}