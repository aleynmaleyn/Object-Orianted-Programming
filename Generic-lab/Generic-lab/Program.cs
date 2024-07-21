using System;
using System.Collections.Generic;

namespace Generic_lab
{

    internal class Program
    {
        static void Main(string[] args)
        {
            GenericOrnek gs = new GenericOrnek();
            gs.ElemanEkle("a");
            gs.ElemanEkle("b");
            gs.ElemanEkle("c");
            gs.ElemanEkle("d");

            gs.Yazdir(gs.genericlistestring);

            Console.WriteLine("*****************");

            gs.ElemanCikar("a");

            gs.Yazdir(gs.genericlistestring);

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("**********");
            }
            gs.ElemanEkle(5);
            gs.ElemanEkle(8);
            gs.ElemanEkle(4);

            gs.Yazdir(gs.genericlisteint);
        }
    }
    class GenericOrnek
    {
        public List<string> genericlistestring = new List<string>();
        public List<int> genericlisteint = new List<int>();

        public void ElemanEkle(string a)
        {
            genericlistestring.Add(a);
        }
        public void ElemanEkle(int a)
        {
            genericlisteint.Add(a);
        }
        public void ElemanCikar(string a)
        {
            genericlistestring.Remove(a);
        }
        public void ElemanCikar(int a)
        {
            genericlisteint.Remove(a);
        }
        public void Yazdir(List<string> l)
        {
            foreach (string s in l)
            {
                Console.WriteLine(s);
            }
        }
        public void Yazdir(List<int> l)
        {
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}