using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {

        private static void print(string key,int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(i+1 +"-"+ key);
            }
        }

        private static int Topla(int s1,int s2)
        {
            int toplam = s1 + s2;

            return toplam;
        }

        int Çarpma(int s1, int s2)
        {
            return s1 * s2;
        }

        static void Main(string[] args)
        {
            //Console.Write("Yazdırmak istediğiniz Metni giriniz : ");
            //string key = Console.ReadLine();
            //Console.Write("Kaç kere yazdırılsın: ");
            //int value  = Convert.ToInt32(Console.ReadLine());
            //print(key,value);

            //Console.WriteLine("Toplam :{0}",Topla(5,8));

            Program prg = new Program();
            Console.WriteLine(prg.Çarpma(5,6));

            Console.ReadLine();

        }
    }
}
