using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("aleyna");
        list.Add("veysel");
        list.Add("zehra");
        list.Add("yiğitemir");

        if (list.Contains("veysel"))
        {
            Console.WriteLine("veysel bulundu.");
        }



        if (list.Contains("ZEHRA", StringComparer.OrdinalIgnoreCase))
        {
            Console.WriteLine("zehra bulundu");
        }

        Console.WriteLine(list.Contains("ayşe"));//false döndürür.


        Console.ReadLine();
    }
}
