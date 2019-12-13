using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class KuponGen
    {
        public static void kuponGen()
        {
            DateTime dato = DateTime.UtcNow.Date;
            NoDubRow rows = new NoDubRow();
            Console.WriteLine($"    Lotto { dato.ToString("dd-MM-yyyy")}\n\n         1-uge\n       LYN-LOTTO\n");
            Console.Write("1.  ");
            rows.RowGen();
            Console.Write("2.  ");
            rows.RowGen2();
            Console.Write("3.  ");
            rows.RowGen3();
            Console.Write("4.  ");
            rows.RowGen4();
            Console.Write("5.  ");
            rows.RowGen5();
            Console.Write("6.  ");
            rows.RowGen6();
            Console.Write("7.  ");
            rows.RowGen7();
            Console.Write("8.  ");
            rows.RowGen8();
            Console.Write("9.  ");
            rows.RowGen9();
            Console.Write("10. ");
            rows.RowGen10();
            Console.WriteLine();
        }
    }
}
