using DataStructureProblem.OrderedList;
using DataStructureProblem.UnorderedList;
using System;

namespace DataStructureProblem.Files;

class program
{
    static string filepath = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\Files\Search.txt";
    static string filepath1 = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\UnorderedList\UnorderedList.txt";
    static string filepath2 = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\OrderedList\orderedList.txt";
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter the option to Execute\n1.Binary Search\n2.Anagram\n3.Replace String\n4.Insertion Sort\n5.Bubble Sort\n6.Prime Number\n7.Palindrome Number\n8.UnOrdered List\n9.Ordered List\n10.Exit");
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
                    insertionsort.insertionsort(filepath);
                    break;
                case 5:
                    BubbleSort bubble = new BubbleSort();
                    bubble.bubblesort(filepath);
                    break;
                case 6:
                    PrimeNumber prime = new PrimeNumber();
                    prime.primenumber();
                    break;
                case 7:
                    PalindromeAndAnagram palindromeAndAnagram = new PalindromeAndAnagram();
                    palindromeAndAnagram.palindromeandanagram();
                    palindromeAndAnagram.Palindrome();
                 //   palindromeAndAnagram.Anagram();
                    break;
                case 8:
                    Operation operation = new Operation();
                    operation.ReadFileAndPerformOperation(filepath1);
                    break;
                case 9:
                    Operation1 operation1 = new Operation1();
                    operation1.ReadFileAndPerformOperation1(filepath2);
                    break;
                case 10:
                    flag = false;
                    break;
            }   
        }
    }
}