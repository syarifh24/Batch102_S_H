using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan No Soal Logic 4 : ");
            int soal = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("MAsukan Jumlah Array (n) : ");
            int n=int.Parse(Console.ReadLine());

            switch(soal)
            {
                case 1:
                    soal1 Soal1=new soal1(n);
                    break;
                case 2:
                    soal2 Soal2 = new soal2(n);
                    break;

                case 3:
                    soal3 Soal3 = new soal3(n);
                    break;

                case 4:
                    soal4 Soal4 = new soal4(n);
                    break;

                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
