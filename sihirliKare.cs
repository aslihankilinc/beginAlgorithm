using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginAlgorithm
{
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text;
    using System;

    class Result
    {

        // static int[,] array = new int[3, 3] { { 4, 8, 2 }, { 4, 5, 7 }, { 6, 1, 6 } };
        static int[,] array = new int[3, 3] { { 5, 3, 4 }, { 1, 5, 8 }, { 6, 4, 2 } };
        static int result=0;
       

        public static void formingMagicSquare(List<List<int>> s)
        {
            int[][] array = s.Select(c => c.ToArray()).ToArray();
            int a = 0;
            int t = (int)(3 * (Math.Pow(3, 2) + 1)) / 2;
            Random rand = new Random();
        topla:
            int tX = 0;
            int tY = 0;
            for (int i = 0; i < 3; i++)
            {
                tX += array[a][i];
                tY += array[i][a];
            }
            if (tX != tY || (tX != t || tY != t))
            {
                if (tX != t)
                {
                    int f = t - tX;
                    short index = (short)rand.Next(1, 3);
                    array[a][index] = array[a][index] + f;
                }
                if (tY != t)
                {
                    int f = t - tY;
                    short index = (short)rand.Next(1, 3);
                    array[index][a] = array[index][a] + f;
                }
                goto topla;
            }
            else if (a < 2)
            {
                a++;
                result++;
                goto topla;
            }
        }

       
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int a = 0;
            int t = (int)(3 *(Math.Pow(3,2) + 1)) / 2;
            Random rand = new Random();
        topla:
            int tX = 0;
            int tY = 0;
            for (int i = 0; i < 3; i++)
            {
                tX += array[a, i];
                tY += array[i,a];
            }
            if(tX!=tY || (tX != t || tY != t))
            {
                if (tX !=t)
                {
                    int f = t - tX;
                    short index = (short)rand.Next(1, 3);
                    array[a, index] = array[a, index] + f;
                }
                if (tY != t)
                {
                    int f = t - tY;
                    short index = (short)rand.Next(1, 3);
                    array[index,a] = array[index,a] + f;
                }
                goto topla;
            }
            else if(a<2)
            {
                a++;
                result++;
                goto topla;
            }   

            Console.WriteLine(result);
            Console.ReadKey();

        }

    }

}
