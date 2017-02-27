using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic4
{
    class soal4
    {
        public soal4(int n)
        {
            int nP = n;
            int nL = (n * 2)-1;
            int nT = (nL - 1) / 2;
            int bKanan = nT;
            int bKiri = nT;
           // int angka=0;
            string[] strHuruf = new string[9]{ "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            string[,] array2d = new string[nP,nL]; //ini buat nampung /tangkap ke array sebelum di cetak
            for (int i = 0; i < nP; i++)
            {
                int angka = 1;
                for (int j = 0; j < nL; j++)
                {
                    if(j>=bKiri && j<=bKanan)
                    {
                        array2d[i,j]=strHuruf[angka-1];
                       // Console.Write(strHuruf[i]+"\t");
                        angka++;
                    }
                }
                bKiri--;
                bKanan++;
            }


            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if (array2d[i,j] !="")  // tidak bisa gunakan operator > 0 atau < 0 maka pake "null"
                        Console.Write(array2d[i, j] + "\t");
                    else
                        Console.Write("\t");

                }

                Console.WriteLine();
            }
            



        }
    }
}
