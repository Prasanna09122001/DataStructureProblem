using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem.UnorderedList
{
    internal class Operation
    {
        List<string> list = new List<string>();
        public void ReadFileAndPerformOperation(string filepath)
        { 
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                list.Add(data);
            }
            Console.WriteLine("Before Text:");
            list.Display();
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            int position = list.search(word);
            if(position == -1)
            {
                list.Add(word);
            }
            else
            {
                list.DeleteNodeAtParticularPosition(position);
            }
            Console.WriteLine("\nAfter Text:");
            list.Display();
        }
        public void WriteToFile(string filepath)
        {
            string content = string.Join(",", list);
            Console.WriteLine(content);
            File.WriteAllText(filepath, content);
        }
    }
}
