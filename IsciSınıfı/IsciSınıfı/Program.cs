
using System;
using System.Windows;
class Program
{
    public class Isci
    {
        private int kimlikNo;

        public int KimlikNo
        {
            get
            {
                return kimlikNo;
            }
            set
            {
                if (value < 0)
                {
                    kimlikNo = -1;
                }
                else
                {
                    kimlikNo = value;
                }
            }
        }
    }
    static void Main(string[] args)
    {
        Isci usta = new Isci();
        usta.KimlikNo = -14;

        MessageBox.Show("Kimlik NO: " + usta.KimlikNo);

    }
}

