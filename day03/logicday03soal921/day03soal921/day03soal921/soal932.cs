using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03soal921
{
    class soal932
    {
        public soal932()
        {
            int n=5;
            int nP = n; // batas panjang
            int nL = (n * 2) - 1;   //batas lebar
            int nKiri = n;  //batas kiri
            int nKanan = n; //batas kanan
            int[,] array = new int[nP, nL];

            for (int i = 0; i < nP; i++)
            {
                int angka = 1;
                for (int j = 0; j < nL; j++)    //lebar ada di bawah
                {
                    if (j >= nKiri - 1 && j <= nKanan - 1)
                    {
                        array[i, j] = angka;
                        angka++;
                    }
                }
                nKiri--;
                nKanan++;

            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                        Console.Write(array[i, j].ToString() + "\t");
                    else
                        Console.Write("\t");

                }

                Console.WriteLine();
            }
        }
    }
}
