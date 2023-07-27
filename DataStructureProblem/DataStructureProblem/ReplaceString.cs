using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class ReplaceString
    {
        public void replacestring()
        {
            string line = "Hello <<name>>, We have your fullname as << full name >> in our system. your contact number is 91 -<<xxxxxxxxxx>>. Please,let us know in case of any clarification Thank you BridgeLabz 01 / 01 / 2016.";
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            line = line.Replace("<<name>>",Name);
            Console.WriteLine("Enter Full Name");
            string fullName = Console.ReadLine();
            line = line.Replace("<< full name >>", fullName);
            Console.WriteLine("Enter Your Phone Number");
            string phonenumber = Console.ReadLine();
            line = line.Replace("<<xxxxxxxxxx>>", phonenumber);
            Console.WriteLine(line);

        }
    }
}
