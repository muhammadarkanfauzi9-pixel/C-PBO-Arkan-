using System;

public class Looping
{
    public static void jalankanlooping()
    {
        int nilai = 1;
        for(int i = 0; i < 5; i++)
        {
            Console.Write(nilai);
            nilai += 2;
        }
    }
}