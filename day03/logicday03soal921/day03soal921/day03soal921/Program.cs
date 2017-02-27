using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03soal921
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan No Soal : ");
            int n = int.Parse(Console.ReadLine());
            
            switch(n)
            {
                case 1:
                    soal931 soal1 = new soal931(); 
                    break;
                case 2:
                    soal932 soal2 = new soal932(); 
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }

      /*  public static void soal1()
        {
            
        } */

      /*  public static void soal2(int n)
        {
            
        } */
        



    }
}
