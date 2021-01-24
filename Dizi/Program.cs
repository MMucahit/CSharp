using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] dizi = new int[2, 2];

            dizi[0, 0] = 10;
            dizi[0, 1] = 30;
            dizi[1, 0] = 20;
            dizi[1, 1] = 40;

            int[,] matris = new int[2, 2];

            matris[0, 0] = 50;
            matris[0, 1] = 70;
            matris[1, 0] = 60;
            matris[1, 1] = 80;

            int[,] toplam = new int[2, 2];


            for (int i = 0; i <= dizi.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= dizi.GetUpperBound(1); j++)
                {
                    Console.Write("{0} ", dizi[i, j]);
                    Console.Write("{0} ", matris[i, j]);
                }
                Console.WriteLine();
            }


            for (int i = 0; i <= dizi.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= dizi.GetUpperBound(1); j++)
                {
                    toplam[i,j] = dizi[i,j] + matris[i,j];
                    Console.Write("{0} ",toplam[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }


    }


}





    //    private static bool KartKontrol(string v)
    //    {
    //        int toplam = 0;

    //        for (int i = 0; i < 16; i++)
    //        {
    //            int sayı = Convert.ToInt32(v[i].ToString());

    //            if (i % 2 == 0)
    //            {
    //                sayı = sayı * 2;

    //                if (sayı.ToString().Length == 2)
    //                {
    //                    sayı = Convert.ToInt32(sayı.ToString().Substring(0, 1)) + Convert.ToInt32(sayı.ToString().Substring(1, 1));

    //                }

    //            }

    //            toplam += sayı;
    //            Console.WriteLine("{0}. toplam: {1}", i, toplam);

    //        }

    //        if (toplam % 10 == 0)
    //        {
    //            return true;
    //        }

    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}



