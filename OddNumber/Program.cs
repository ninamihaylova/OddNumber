﻿class OddNumber
{
    public static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        while (num %2==0)
        {
            num = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine(num);
    }
}