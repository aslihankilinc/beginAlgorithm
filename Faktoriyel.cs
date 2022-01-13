using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace beginAlgorithm
{

    class Faktoriyel
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger result = new BigInteger(1);
           // long result = 1;
           
                for (long i = 1; i<n; i++)
                {
                result *= i;
                Console.WriteLine(result.ToString()+"  "+i.ToString());
            }
            string a = result.ToString();
                Console.WriteLine(result.ToString());
         
            

        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            extraLongFactorials(45);
            Console.ReadLine();
        }
    }
}
