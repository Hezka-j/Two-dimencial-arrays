//заполнить двумерный массив размереностью N x M по спирали. Число 1 ставиться в центр массива, а затем массив заполняется
//по спирали против часовой стрелки значения по возрастанию.

//заполнить массив размереностью N x M следующим образом:
//1    2    3    4    5    6
//7    8    9    10   11   12
//13   14   15   16   17   18   
//19   20   21   22   23   24
//25   26   27   28   29   30

//заполнить массив размерностью N x M следующим образом
//1   2   3   4   5   6
//12   11   10   9   8   7
//13   14   15   16   17   18
//24   23   22   21   20   19
//25   26   27   28   29   30

//заполнить трёхмерный массив N x N x N нулями. В получившийся куб вписать шар, состоящий из единиц.
//После чего, разрезать куб на N слоёв, и показать каждый слой в виде двумерного массива N x N на экране консоли.
//
using Microsoft.VisualBasic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Двумерные_массивы_c_
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            int[,] mass = new int[5,6];
            int count = 1;
            //for(int y = 0; y < mass.GetLength(0); y++) {
            //    for(int x = 0; x < mass.GetLength(1); x++)
            //    {
            //        mass[y, x] = count++;
            //    }               
            //}

            //for (int y = 0; y < mass.GetLength(0); y++)
            //{
            //    for (int x = 0; x < mass.GetLength(1); x++)
            //    {
            //        Console.Write(mass[y, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //3
            for(int y = 0; y < mass.GetLength(0); y++) {
                for(int x = 0; x < mass.GetLength(1); x++) { 
                   
                    if(y + 1 % 2 != 0 && x == mass.GetLength(1) - 1 && y != 4)
                    {
                        mass[y, x] = count;
                        y++;
                        while(x != 0) {
                            count++;
                            mass[y, x] = count;
                            x--;
                            
                        }
                        count++;
                        mass[y, x] = count;
                        y++;
                        count++;
                        
                    }
                    mass[y, x] = count;
                    count++;
                }
            }

            for(int y = 0; y < mass.GetLength(0); y++) {
               for(int x = 0; x < mass.GetLength(1); x++) {
                    Console.Write(mass[y,x] + "\t");
                }
               Console.WriteLine();
            }
    }
    }
}