﻿using System;
class Program
{
    static void Yaz(object o)
    {
        Console.WriteLine("1.Metot: " + o);
    }
    static void Yaz(params object[] o)
    {
        if (o.Length == 0)
        {
            return;
        }
        Console.Write("2.Metot: ");

        foreach (object n in o)
        {
            Console.Write(n.ToString() + " ");
            
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        Yaz(25);
        Yaz("Deneme1", "Deneme2");
        Yaz('a');
        Yaz('v', 1, 23f, 4, 56, "ALEYNA");
        Console.Read();
    }
}