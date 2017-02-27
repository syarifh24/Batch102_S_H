using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day03soal921
{
    class soal931
    {
        public soal931()
        {
            int n = 5;
            int nilai = 0;
            int[] tangkap = new int[(n * 2)];
            int a = 0;
            for (int b = 0; b < 2; b++)
            {   //rumah bata

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0)
                        {
                            if (b == 0)
                            {
                                nilai += 1;
                            }
                            else
                            {
                                nilai -= 1;
                            }
                            tangkap[a] = nilai; //untuk di tangkap dulu dalam array sebelum dicetak



                            if (a < 9) //di buat agar yg tercetak hanya sampai index ke [8] atau 9 digit saja
                            {
                                Console.Write(tangkap[a]);
                                a += 1;
                            }


                        }
                    }
                }

            }   //rumah bata

        }
    }
}
