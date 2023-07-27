using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class Insertionsort
    {
        public void insertionsort(string Filepath)
        {
            string readAllText = File.ReadAllText(Filepath);
            string arr = readAllText.Replace(",","");
            char[] array= arr.ToCharArray();
            for(int i=1;i<array.Length;i++)
            {
                char a = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > a )
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = a;
            }
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
