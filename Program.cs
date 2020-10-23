using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ElementsNesting
{
    class Program
    {
        //сделать разные методы для одномерных и многомерных массивов, т.к для них должен быть разный подход
        static string oneDimension(System.Array array)
        {
            string str = "";
            foreach (var item in array)
            {
                str += item + ",";
            }
            return str;
        }

        static string twoDimensions(int[,] array)
        {
            string str = "";
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int l = 0; l < array.GetLength(1); l++)
                {
                    str += array[k,l] + ",";
                }
                str += ".";
            }
            return str;
        }
        static bool isNested(System.Array array1, System.Array array2)
        {
            string strArray1;
            string strArray2;

            if (array1.Rank == 1) strArray1 = oneDimension(array1);
            else strArray1 = twoDimensions((int[,])array1);

            if (array2.Rank == 1) strArray2 = oneDimension(array2);
            else strArray2 = twoDimensions((int[,])array2);

            if (strArray1.Contains(strArray2)) return true;
            else if (strArray2 == "") return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int[,] firstArr = { { 1, 2, 3 }, { 3, 4, 5 }, { 7, 8, 9 } };
            int[,] secondArr = { { 3, 4, 5 }, { 7, 8, 9 } };
            Console.WriteLine(isNested(firstArr, secondArr));
            Console.ReadKey();

        }
    }
}
