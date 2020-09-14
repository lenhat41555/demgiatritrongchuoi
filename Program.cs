using System;

namespace demgiatritrongchuoi
{
    class Program
    {
        static void Main(string[] args)
        {
           string str1; //khai bao chuoi ban dau
            string chuoi_con; //khai bao chuoi con can tim
            int strt = 0;
            int cnt = -1;
            int idx = -1;

            Console.Write("\nDem so lan xuat hien cua chuoi con :\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap chuoi ban dau: ");
            str1 = Console.ReadLine();
            Console.Write("Nhap chuoi con can tim: ");
            chuoi_con = Console.ReadLine();


            while (strt != -1)
            {
                strt = str1.IndexOf(chuoi_con, idx + 1);
                cnt += 1;
                idx = strt;
            }
            Console.Write("Chuoi con '{0}' xuat hien " + cnt + " lan.\n", chuoi_con);  

            Console.ReadKey();
        }
    }
}
