using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    public class NoDubRow
    {
        public string name;
        Random rng = new Random();

        public void RowGen()
        {
            int[] row = new int[7];        
            int temp;
                        

            for (int i = 0; i < row.Length; i++)
            {
                temp = rng.Next(1,37);
                while (DubCheck(temp, row))
                {
                    temp = rng.Next(8);
                }
                row[i] = temp;
            }
            SortedNumbers(row);
            PrintTheArray(row);
            //row = new int[7];
                        
        }

        public void RowGen2()
        {
            int[] row2 = new int[7];
            int temp2;

            for (int i = 0; i < row2.Length; i++)
            {
                temp2 = rng.Next(1, 37);
                while (DubCheck(temp2, row2))
                {
                    temp2 = rng.Next(8);
                }
                row2[i] = temp2;
            }
            SortedNumbers(row2);
            PrintTheArray(row2);
        }

        public void RowGen3()
        {
            int[] row3 = new int[7];
            int temp3;

            for (int i = 0; i < row3.Length; i++)
            {
                temp3 = rng.Next(1, 37);
                while (DubCheck(temp3, row3))
                {
                    temp3 = rng.Next(8);
                }
                row3[i] = temp3;
            }
            SortedNumbers(row3);
            PrintTheArray(row3);
        }

        public void RowGen4()
        {
            int[] row4 = new int[7];
            int temp4;

            for (int i = 0; i < row4.Length; i++)
            {
                temp4 = rng.Next(1, 37);
                while (DubCheck(temp4, row4))
                {
                    temp4 = rng.Next(8);
                }
                row4[i] = temp4;
            }
            SortedNumbers(row4);
            PrintTheArray(row4);
        }

        public void RowGen5()
        {
            int[] row5 = new int[7];
            int temp5;

            for (int i = 0; i < row5.Length; i++)
            {
                temp5 = rng.Next(1, 37);
                while (DubCheck(temp5, row5))
                {
                    temp5 = rng.Next(8);
                }
                row5[i] = temp5;
            }
            SortedNumbers(row5);
            PrintTheArray(row5);
        }

        public void RowGen6()
        {
            int[] row6 = new int[7];
            int temp6;

            for (int i = 0; i < row6.Length; i++)
            {
                temp6 = rng.Next(1, 37);
                while (DubCheck(temp6, row6))
                {
                    temp6 = rng.Next(8);
                }
                row6[i] = temp6;
            }
            SortedNumbers(row6);
            PrintTheArray(row6);
        }

        public void RowGen7()
        {
            int[] row7 = new int[7];
            int temp7;

            for (int i = 0; i < row7.Length; i++)
            {
                temp7 = rng.Next(1, 37);
                while (DubCheck(temp7, row7))
                {
                    temp7 = rng.Next(8);
                }
                row7[i] = temp7;
            }
            SortedNumbers(row7);
            PrintTheArray(row7);
        }

        public void RowGen8()
        {
            int[] row8 = new int[7];
            int temp8;

            for (int i = 0; i < row8.Length; i++)
            {
                temp8 = rng.Next(1, 37);
                while (DubCheck(temp8, row8))
                {
                    temp8 = rng.Next(8);
                }
                row8[i] = temp8;
            }
            SortedNumbers(row8);
            PrintTheArray(row8);
        }

        public void RowGen9()
        {
            int[] row9 = new int[7];
            int temp9;

            for (int i = 0; i < row9.Length; i++)
            {
                temp9 = rng.Next(1, 37);
                while (DubCheck(temp9, row9))
                {
                    temp9 = rng.Next(8);
                }
                row9[i] = temp9;
            }
            SortedNumbers(row9);
            PrintTheArray(row9);
        }

        public void RowGen10()
        {
            int[] row10 = new int[7];
            int temp10;

            for (int i = 0; i < row10.Length; i++)
            {
                temp10 = rng.Next(1, 37);
                while (DubCheck(temp10, row10))
                {
                    temp10 = rng.Next(8);
                }
                row10[i] = temp10;
            }
            SortedNumbers(row10);
            PrintTheArray(row10);
        }


        public void SortedNumbers(int[] row)
        {
            Array.Sort(row);
        }
        public void PrintTheArray(int[] row)
        {
            foreach (int number in row)
            {

                Console.Write("{0:D2} ", number);
            }
            Console.WriteLine();
        }
        public bool DubCheck(int temp, int[] row)
        {
            foreach (int number in row)
            {
                if (number == temp)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
