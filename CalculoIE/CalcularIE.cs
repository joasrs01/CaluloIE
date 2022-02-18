using System;
using System.Windows.Forms;

namespace CalculoIE
{
    public class CalcularIE
    {
        public int Calculo(string IE)
        {
            int nIE = int.Parse(IE);
            int[] n = new int[9];
            int per = 1;

            for (int i = 0; i < 9; i++)
            {
                n[i] = (nIE / per) % 10;
                per *= 10;
            }

            if (n[8] != 0 && n[7] != 3)
            {
                return 1;
            }

            string[] ns = new string[9];

            for (int i = 0; i < 9; i++)
            {
                ns[i] = n[i].ToString();
            }

            string nsemdigito = $"{ns[8]}{ns[7]}{ns[6]}{ns[5]}{ns[4]}{ns[3]}{ns[2]}{ns[1]}";
            int ntotal = int.Parse(nsemdigito);

            int p = 0;
            int d = 0;

            if (ntotal >= 3000001 && ntotal <= 3017000)
            {
                p = 5;
            }
            else if (ntotal >= 3017001 && ntotal <= 3019022)
            {
                p = 9;
                d = 1;
            }

            int r0, r1, r2, r3, r4, r5, r6, r7;
            int tot = 0;

            r0 = n[8] * 9;
            r1 = n[7] * 8;
            r2 = n[6] * 7;
            r3 = n[5] * 6;
            r4 = n[4] * 5;
            r5 = n[3] * 4;
            r6 = n[2] * 3;
            r7 = n[1] * 2;

            tot += r0 + r1 + r2 + r3 + r4 + r5 + r6 + r7 + p;

            int resto = tot % 11;
            int v = (11 - resto);
            int verificador1 = 0;

            if (v == 10)
            {
                verificador1 = 0;
            }
            else if (v == 11)
            {
                verificador1 = d;
            }
            else
            {
                verificador1 = v;
            }

            if (n[0] == verificador1)
            {
                return 2;
            }
            else
            {
                return 3;
            }           
        }
    }
}
