using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem.OrderedList
{
    internal class Operation1
    {
        public void ReadFileAndPerformOperation1(string filepath)
        {
            List list = new List();
            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(",");
            foreach (var data in words)
            {
                list.Add(Convert.ToInt32(data));
            }
            Console.WriteLine("Before Text:");
            list.Display(words.Length);
            Console.WriteLine("\nAfter Text:");
            list.Operation(90,words.Length);
        }
    }
}
