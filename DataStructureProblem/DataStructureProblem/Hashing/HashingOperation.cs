using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureProblem.UnorderedList;
using DataStructureProblem.OrderedList;

namespace DataStructureProblem.Hashing
{
    public class HashingOperation
    {
        static int size = 11;
        List[] array1 = new List[size];
        public HashingOperation()
        {
            for(int i=0;i<size;i++)
            {
                array1[i] = new List();
            }
        }
        public void ReadFile(string filepath)
        {
            string ReadAllText = File.ReadAllText(filepath);
            string[] words = ReadAllText.Split(",");
            foreach(var data in words)
            {
                int num = Convert.ToInt32(data);
                int position = num % size;
                array1[position].Add(num);
            }
        }
        public void Display()
        {
            foreach( var data in array1)
            {
                data.Display();
                Console.WriteLine();

            }
        }
    }
}
