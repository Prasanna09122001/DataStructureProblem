using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureProblem.UnorderedList;

namespace DataStructureProblem.BalancedParenthesis
{
    internal class Operation2
    {
        stack<string> list = new stack<string>();
        public void ReadAndPerformOperation(string filepath)
        {

            string readAllText = File.ReadAllText(filepath);
            string[] words = readAllText.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals("("))
                    list.Push(data);
                if (data.Equals(")"))
                    list.Pop();
            }
            if (list.IsEmpty())
                Console.WriteLine("Balanced Paranthesis");
            else
                Console.WriteLine("Not a Balanced Paranthesis");
        }
    }
}
