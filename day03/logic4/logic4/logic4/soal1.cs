using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic4
{
    class soal1
    {
        public soal1(int n) // ketik ctor+Tab
        {
           // int n = 5;
            int nP = n;// batas panjang
            int nL = (n*2)-1;   //batas lebar
            int nT = (nL - 1) / 2;
            int bKiri = nT;  //batas kiri
            int bKanan = nT; //batas kanan
            int[,] array = new int[nP, nL];

            for (int i = 0; i < nP; i++)
            {
                int angka = 1;
                for (int j = 0; j < nL; j++)    //lebar ada di bawah
                {
                    if (j >= bKiri && j <= bKanan)
                    
                    {
                        //Console.Write("*");
                        array[i, j] = angka;
                        angka++;
                    }
                 //   Console.Write("\t");
                }
                bKiri--; //setelah perulangan pada for i
                bKanan++;
              //  Console.WriteLine("\t");
            }
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                        Console.Write(array[i, j] + "\t");
                    else
                        Console.Write("\t");

                }

                Console.WriteLine();
            }
            
        }
    }
}
