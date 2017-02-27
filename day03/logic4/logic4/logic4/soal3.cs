using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic4
{
    class soal3
    {
        public soal3(int n)
        {

            int nP = n;
            int nL = n;
            int nT = (n - 1) / 2;
            int bKanan = nT;
            int bKiri = nT;
            int[,] array2d = new int[nL, nP];
            //int angka = 0;

            for (int i = 0; i < nP; i++)
            {
                int angka = 1;
                for (int j = 0; j < nL; j++)
                {
                    if (j >=bKiri && j<=bKanan)
                    {
                        array2d[i, j] = angka;
                        //Console.Write("*\t");
                        angka++;
                    }
                   /* else
                    {
                        Console.Write("\t");
                    }*/
                }
               // Console.WriteLine();

                //jika i dari indeks ke no sampai indeks ke 4
                if (i < nT)
                {
                    bKanan++;
                    bKiri--;
                }
                    //jika i dari indeks ke 5 sampai indeks ke n
                else
                {
                    bKanan--;
                    bKiri++;
                }
            }

            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    //jika array nya bernilai lebih dari nol
                    if (array2d[i,j] > 0)    
                    {
                        Console.Write(array2d[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
