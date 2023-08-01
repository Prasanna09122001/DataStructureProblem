using DataStructureProblem.BalancedParenthesis;
using DataStructureProblem.BankProblem;
using DataStructureProblem.OrderedList;
using DataStructureProblem.UnorderedList;
using DataStructureProblem.Hashing;
using System;

namespace DataStructureProblem.Files;

class program
{
    static string filepath = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\Files\Search.txt";
    static string filepath1 = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\UnorderedList\UnorderedList.txt";
    static string filepath2 = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\OrderedList\orderedList.txt";
    static string filepath3 = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\BalancedParenthesis\Balanced.txt";
    static string filepath4 = @"D:\Bridgelabz Statement\DataStructureProblem\DataStructureProblem\DataStructureProblem\DataStructureProblem\Hashing\HashTable.txt";
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter the option to Execute\n1.Binary Search\n2.Anagram\n3.Replace String\n4.Insertion Sort\n5.Bubble Sort\n6.Prime Number\n7.Palindrome Number\n8.UnOrdered List\n9.Ordered List");
            Console.WriteLine("10.Balanced parenthesis\n11.Bank Balance\n12.Exit");         
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
                    palindromeAndAnagram.Anagram();
                    break;
                case 8:
                    Operation operation = new Operation();
                    operation.ReadFileAndPerformOperation(filepath1);
                    operation.WriteToFile(filepath1);
                    break;
                case 9:
                    Operation1 operation1 = new Operation1();
                    operation1.ReadFileAndPerformOperation1(filepath2);
                    break;
                case 10:
                    Operation2 operation2 = new Operation2();
                    operation2.ReadAndPerformOperation(filepath3);
                    break;
                case 11:
                    Bank bank = new Bank();
                    bank.Balance(0);
                    bank.AddPersonsInQueue();
                    break;
                case 12:
                    HashingOperation hashingOperation = new HashingOperation();
                    hashingOperation.ReadFile(filepath4);
                    hashingOperation.Display();
                    break;
                case 13:
                    flag = false;
                    break;
            }   
        }
    }
}