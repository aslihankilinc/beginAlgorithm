using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginAlgorithm
{

    class beetweenTwoSets
    {
        public static int getTotalX(List<int> a, List<int> b)
        {

            int total = 0;
            int aMax = a.Max();
            int bMin = b.Min();
            int count = 1;
            int aLimit = aMax;

            while (aLimit <= bMin)
            {
                bool statu = true;
                foreach (var item in a)
                {
                    if (aLimit % item != 0)
                    {
                        statu = false;
                        break;
                    }
                }
                if (statu)
                {
                    foreach (var item in b)
                    {
                        if (item % aLimit != 0)
                        {
                            statu = false;
                            break;
                        }
                    }
                }
                if (statu)
                    total++;

                count++;

                aLimit = aMax * count;
            }
     
            return total;
        }
        static void Main(String[] args)
        {
            var a= Console.ReadLine().Split(' ');
            var aList = Array.ConvertAll(a, Int32.Parse);
            var b= Console.ReadLine().Split(' ');
            var bList = Array.ConvertAll(b, Int32.Parse);

            int total = getTotalX(a.ToList(), b.ToList());
            Console.WriteLine(total);
            Console.ReadLine();
        }
       



    }
}
