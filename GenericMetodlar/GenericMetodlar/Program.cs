using System;

namespace GenericMetodlar
{
    class Program
    {
        static void Topla<T>(T a, T b)
        {
            Console.WriteLine(a + " " + b);
        }

        static void FarkliTip<T, K>(T a, K b)
        {
            Console.WriteLine("FARKLI TİP GENERİC ÇALIŞTI");
        }

        static T GeriyeDeger<T>(T a)
        {
            Console.WriteLine("GERİYE DEĞER DÖNDÜR");
            return a;
        }

        static void Main(string[] args)
        {
            Topla<int>(5, 3);
            Topla<byte>(1, 2);
            FarkliTip<int, byte>(5, 9);
            int d = GeriyeDeger<int>(5);
            int a = 21;
            int b = 45;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            Console.ReadLine();
        }
    }
}



/*
public class GenericClass<T>where T: struct
{
    //sadece değer türleri için 
}
public class GenericClass<T> where T : class
{
    //sadece referans türleri için
}
public class GenericClass<T> where T : new()
{
    //parametresiz kurucu metodu olmalı

    public T CreateInstance()
    {
        return new T();
    }
}
public class GenericClass<T> where T : BaseClass
{
    //T,BaseClasstan türemiş olmalı
}
public class GenericClass<T> where T : IComparable
{
    //T,IComparable arayüzünü uygulamalı
}
public class GenericClass<T> where T : U 
{ 
    //T,U DAN TÜREMİŞ OLMALI
}

*/