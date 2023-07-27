using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class BubbleSort
    {
        public void bubblesort()
        {
            Console.WriteLine("Enter the Length of the Array");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements of the Array");
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<length-1;i++)
            {
                for(int j=0;j<length-i-1;j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for(int i=0;i<length;i++)
            {
                Console.WriteLine(array[i]+" ");
            }
        }
    }
}
