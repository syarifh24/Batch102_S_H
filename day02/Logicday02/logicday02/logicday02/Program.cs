using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicday02
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {

                try
                {
                    Console.WriteLine("Masukan No Soal : ");
                    int soal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Masukan Angka : ");
                    int n = int.Parse(Console.ReadLine()); //deklarasi n agar jumlah bintang y bisa berubah sesuai yg kita input
                    //bisa di tambah method ke 2 contoh --> String nama = "Xsis";
                    switch (soal)
                    {
                        case 1: soal1(n); break;
                        case 2: soal2(n); break;
                        case 3: soal3(n); break;
                        default:
                            break;
                    }

                    Console.Write("Apakah Ingin Melanjutkan ? ");
                    string tanya = Console.ReadLine();
                    if (tanya.ToUpper() != "Y")
                    {
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                    Console.ReadLine();
                    continue;
                }

            }

        }
        
        public static void soal1(int n)
        {
            //int n = 9;
            for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   if (i==j || i + j == n - 1 )
                   {
                       Console.Write("*\t");
                   }
                   else
                   {
                       Console.Write("\t");
                   }

               }
               Console.WriteLine("\n\n\n");
           }

        }
        
        public static void soal2(int n)
        {
            //int n = 9;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine("\n\n\n");
            }
        }
        public static void soal3(int n) // int n ini disebut method bisa lebih dari 1 contoh soal3(int n,String nama)
        {
            //int n = 9; jika dideklarasikan disini makan n teteap berjumlah 9
            //cetak String Nama disini --> console.writeline("nama")
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine("\n\n\n");
            }
            //Console.ReadKey;
        }
    }
}
