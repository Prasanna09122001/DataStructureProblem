﻿using System;

namespace DataStructureProblem.Files;

class program
{
    static string filepath = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\Files\Search.txt";
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter the option to Execute\n1.Binary Search\n2.Anagram\n3.Replace String\n4.Exit");
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
                    anagram.checkAnagram();
                    break;
                case 3:
                    ReplaceString replaceString = new ReplaceString();
                    replaceString.replacestring();
                    break;
                case 4:
                    Insertionsort insertionsort = new Insertionsort();
                    insertionsort.insertionsort();
                    break;
                case 5:
                    flag = false;
                    break;
            }   
        }
    }
}