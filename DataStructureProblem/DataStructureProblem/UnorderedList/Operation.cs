using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem.UnorderedList
{
    internal class Operation
    {
        public void ReadFileAndPerformOperation(string filepath)
        {
            List<string> list = new List<string>();
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                list.Add(data);
            }
            Console.WriteLine("Before Text:");
            list.Display();
            list.Operation("the");
            Console.WriteLine("\nAfter Text:");
            list.Display();
        }
    }
}
