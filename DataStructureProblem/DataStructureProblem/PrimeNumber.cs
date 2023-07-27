using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class PrimeNumber
    {
        public void primenumber()
        {
            for (int i = 1; i < 1000; i++)
            {
                int count = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 1)
                {
                    Console.WriteLine(i + " ");
                }
            }
            
        }
    }
}
