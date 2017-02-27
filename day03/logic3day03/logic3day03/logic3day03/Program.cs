using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic3day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan No Soal : ");
            int soal = int.Parse(Console.ReadLine());

            Console.Write("Masukan Jumlah Array : ");
            int n = int.Parse(Console.ReadLine());

            switch(soal)
            {
                case 1: soal1(n); break;
                case 2: soal2(n); break;
                case 3: soal3(n); break;
                case 4: soal4(n); break;
                case 5: soal5(n); break;
            //    case 6: soal6(n); break;
            //    case 7: soal7(n); break;
            //    case 8: soal8(n); break;
            //    case 9: soal9(n); break;
            //    case 10: soal10(n); break;

                default:
                    break;
            }
            
            Console.ReadKey();
        }

        //1--------------------------------------------------------------

        public static void soal1(int n)
        {
            int[] fibo1 = new int[n];
            int i, j;
            int a = 1, b = 0, c = 0;

            for (i = 0; i < n; i++)
            {
                fibo1[i] = a;
                c = a + b;
                b = a;
                a = c;
            }

            for (j = 0; j < n; j++)
            {
                Console.Write(fibo1[j] + " ");
            }
        }

                //2--------------------------------------------------------------
        public static void soal2(int n)
        {
            Console.WriteLine("\n");
            int p = 1, q = 1, r = 1, s = 0;
            int[] fibo2 = new int[n];
            int i,j;

            for ( i = 0; i < n; i++)
            {
                fibo2[i] = p;
                s = p + q + r;
                p = q;
                q = r;
                r = s;

            }

            for(j=0;j<n;j++)
            {
                Console.Write(fibo2[j]+" ");
            }

        }

            //3------------------------------------------------------------------
            public static void soal3(int n)
            {
                int[] fibo1 = new int[n];
                //int i, j;
                int a = 1, b = 0, c = 0;
                
                for (int i = 0; i < n; i++)
                {
                    fibo1[i] = a;
                                        
                    if (i < (n-1)/2)
                    {
                        //fibo1[i] = a;
                        c = a + b;
                        b = a;
                        a = c;

                    }
                    else
                    {
                        //fibo1[i] = a;
                        c = a - b;
                        a = b;
                        b = c;
                        //fibo1[i] = a;
                    }

                }

                for(int j=0;j<n;j++)
                {
                    Console.Write(fibo1[j] + " ");
                }
            }
            
            //4----------------------------------------------------------------
            public static void soal4(int n)
            {
                int p = 1, q = 1, r = 1, s = 0;
                int[] fibo2 = new int[n];
                int i, j;

                for (i = 0; i < n; i++)
                {
                    fibo2[i] = p;
                    if (i < (n - 1) / 2)
                    {
                        //fibo2[i] = p;
                        s = p + q + r;
                        p = q;
                        q = r;
                        r = s;

                    }
                    else
                    {
                        //fibo2[i] = p;
                        s = r - q - p;
                        r = q;
                        q = p;
                        p = s;
                        
                    }

                }

                for (j=0;j<n;j++)
                {
                    Console.Write(fibo2[j] + " ");
                }

            }

        public static void soal5(int n)
            {
                int[] fibo1 = new int[n];
                //int i, j;
                int a = 1, b = 0, c = 0;
                
                for (int i = 0; i < n; i++)
                {
                    fibo1[i] = a;
                                        
                    if (i < (n-1)/2)
                    {
                        //fibo1[i] = a;
                        c = a + b;
                        b = a;
                        a = c;

                    }
                    else
                    {
                        //fibo1[i] = a;
                        c = a - b;
                        a = b;
                        b = c;
                        
                    }

                }

                for(int j=0;j<n;j++)
                {
                    for (int i = 0; i < n;i++ )
                    {
                        Console.Write(fibo1[j] + " ");
                    }
                }
            
            }


    }
}
