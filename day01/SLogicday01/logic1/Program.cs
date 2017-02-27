using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Masukan Nilai : ");
            int n =int.Parse(Console.ReadLine());
            //Console.Write(n);
            //---------------------------------------
            //Console.ReadLine;           
            Console.Write("\n\n\nNilai yang anda input adalah " + n);
            Console.WriteLine("\n\n");
            //---------------------------------------


           //1---------------------------------------
            /*          
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   if (i==j)
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
           */
            //---------------------------------------

            
             //2---------------------------------------
            /* 
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   if (i+j==n-1)
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
           */
            //---------------------------------------


            //3---------------------------------------
            /* 
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
           */
            //---------------------------------------


            //4---------------------------------------
            /* 
           for (int i = 0; i < n; i++)
           {
               for (int j = 0; j < n; j++)
               {
                   if (i == j || i + j == n - 1 || i==(n-1)/2 || j==(n-1)/2)
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
           */
            //---------------------------------------

            //5---------------------------------------
            /* 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1 || i==0 || j==0 || i==n-1 || j==n-1)
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
                
            */
            //---------------------------------------


            //6---------------------------------------
            /* 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
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

            */
            //---------------------------------------



            //7---------------------------------------
            /* 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= n - 1)
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

            */
            //---------------------------------------

            //8------------------------------------------------------------

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i+j<=n-1 && i<=j || i+j>=n-1 && i>=j)
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
            
           //9---------------------------------------------------------------------- 
            
            Console.WriteLine("\n\n");
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j <= n - 1 && i >= j || i + j >= n - 1 && i <= j)
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

            //10----------cara pertama-----------------------------------------------------------

            Console.WriteLine("\n\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i>=j && i+j <=n-1 && i<=(n-1)/2 )
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

            //10----------cara kedua-----------------------------------------------------

            Console.WriteLine("\n\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j && i <= (n - 1) / 2)
                    {
                        Console.Write("*\t");
                    }
                    else if (i <= j && i >= (n - 1) / 2)
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

            
            //post test--------------------------------------------------------------------
            Console.WriteLine("\n\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j==(n-1)/2 || i==j && i+j>=n-1 || i+j==n-1 && i>=j)
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


            //coba coba----------------------------------------------------------------------
            Console.WriteLine("\n\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j && i <= (n - 1) / 2)
                    {
                        Console.Write("*\t");
                    }
                    else if (i <= j && i >= (n - 1) / 2)
                    {
                        Console.Write("*\t");
                    }

                    else if (i+j >= n-1 && j<=(n-1)/2)
                    {
                        Console.Write("*\t");
                    }

                    else if (i+j <= n-1 && j>=(n-1)/2)
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








                        
            Console.ReadKey();
        }
    }
}
