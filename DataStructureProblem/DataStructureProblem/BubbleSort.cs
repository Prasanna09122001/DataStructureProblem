using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class BubbleSort
    {
        public void bubblesort(string Filepath)
        {
            string readAllText = File.ReadAllText(Filepath);
            string arr = readAllText.Replace(",", "");
            char[] array = arr.ToCharArray();
            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=0;j<array.Length-i-1;j++)
                {
                    if (array[j] > array[j+1])
                    {
                        char temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
