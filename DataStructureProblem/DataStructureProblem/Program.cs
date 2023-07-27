using System;

namespace DataStructureProblem.Files;

class program
{
    static string filepath = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\Files\Search.txt";
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter the option to Execute\n1.Binary Search\n2.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Welcome to Data Structure Problem");
                    BinarySearch binarySearch = new BinarySearch();
                    binarySearch.ReadTextFileAndSearch(filepath);
                    break;
                case 2:
                    Anagram anagram = new Anagram();
                    anagram.CheckAnagram();
                    break;
                case 3:
                    flag = false;
                    break;
            }   
        }
    }
}