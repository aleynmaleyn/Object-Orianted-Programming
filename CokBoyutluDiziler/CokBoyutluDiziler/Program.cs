using System;

class diziler
{
    public static void Main()
    {
        int[,] dizi = new int[4, 4];
        int k = 1;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                dizi[i, j] = k;
                k++;
            }
        }

        k = 1; // k'yı tekrar 1 yapalım, satır ve sütun arasında değişim yapmak için.

        foreach (int x in dizi)
        {
            if (k % 4 == 0)
            {
                Console.Write(x + " ");
                Console.WriteLine();
            }
            else
            {
                Console.Write(x + " ");
            }
            k++;
        }
        Console.ReadLine();
    }
}
