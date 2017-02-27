using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic2day02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan No Soal : ");
            int soal = int.Parse(Console.ReadLine());

            Console.Write("Masukan Jumlah Array : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            switch (soal)
            {
                case 1: soal1(n); break;
                case 2: soal2(n); break;
                case 3: soal3(n); break;
                case 4: soal4(n); break;
                case 5: soal5(n); break;
                case 6: soal6(n); break;
                case 7: soal7(n); break;
                case 8: soal8(n); break;
                case 9: soal9(n); break;
                case 10: soal10(n); break;

                default:
                    break;
            }

            Console.ReadKey();
        }

        
        //1--------------------------------------------------------
        public static void soal1(int n)
        {
            int[] ganjil = new int[n];
            int a = 1;
            
            for (int i=0;i<n;i++)
            {
                  
                   ganjil[i]=a;
                   a=a+2;
                  
            }

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {

                    if (j == k)
                    {
                        Console.Write(ganjil[j]+"\t\t");
                        
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine("\n\n");
            }
        }


        //--------------------------------------------------------
        public static void soal2(int n)
        {
            int[] genap = new int[n];
            int b = 0;

            for (int i = 0; i < n; i++)
            {

                genap[i] = b;
                b = b + 2;

            }

            int z = 0;
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                   
                    if (j+k==n-1)
                    {
                        z = n - (j+1);
                        Console.Write(genap[z] + "\t\t");
                    }   
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine("\n\n");
            }
        
        }


        //--------------------------------------------------------
        public static void soal3(int n)
        {
            int[] ganjil = new int[n];
            int a = 1;
            int[] genap = new int[n];
            int b = 0;
            int z = 0;

            for (int i = 0; i < n; i++)
            {

                ganjil[i] = a;
                a = a + 2;
                genap[i] = b;
                b = b + 2;

            }

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {

                    if (j == k || j + k == n - 1)
                    {
                        Console.Write(ganjil[j] );
                        
                        z = n - (j + 1);
                        Console.Write(genap[z] + "\t");
                        
                    }
                    else
                    {
                        Console.Write("\t");
                    }

                }
                Console.WriteLine("\n\n");
            }


            //batas---------------------------------

        }


        //--------------------------------------------------------
        public static void soal4(int n)
        {

        }


        //--------------------------------------------------------
        public static void soal5(int n)
        {

        }


        //--------------------------------------------------------
        public static void soal6(int n)
        {

        }


        //--------------------------------------------------------
        public static void soal7(int n)
        {

        }


        //--------------------------------------------------------
        public static void soal8(int n)
        {

        }


        //--------------------------------------------------------
        public static void soal9(int n)
        {

        }


        //--------------------------------------------------------
        public static void soal10(int n)
        {

        }
    }
}
