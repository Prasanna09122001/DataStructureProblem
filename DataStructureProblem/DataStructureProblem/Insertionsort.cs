using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class Insertionsort
    {
        public void insertionsort()
        {
            Console.WriteLine("Enter the Length of the Array");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements of the Array");
            int[] array= new int[length];
            for(int i=0;i<length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=1;i<length;i++)
            {
                int a = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > a )
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = a;
            }
            for(int i=0;i<length;i++)
            {
                Console.WriteLine(array[i]+" ");
            }
        }
    }
}
