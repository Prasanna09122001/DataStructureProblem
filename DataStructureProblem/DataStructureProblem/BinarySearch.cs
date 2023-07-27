using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class BinarySearch
    {
        public void ReadTextFileAndSearch(string Filepath)
        {
            string readAllText = File.ReadAllText(Filepath);
            string[] words = readAllText.Split(",");
            Console.WriteLine("Enter the Key to Search");
            string key = Console.ReadLine();
            bool isFind = false;
            foreach (var data in words)
            {
                if (data.Equals(key))
                {
                    isFind = true;
                }
            }
            if (isFind)
                Console.WriteLine("Search Element {0} is found", key);
            else
                Console.WriteLine("Search Element is Not Found");
        }
    }
}
