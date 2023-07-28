using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblem
{
    internal class PalindromeAndAnagram
    {
        List<int> primeNumbers = new List<int>();
        List<int> palindrome = new List<int>();
        public void palindromeandanagram()
        {
            for (int i = 1; i < 1000; i++)
            {
                int count = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 1)
                {
                    primeNumbers.Add(i);
                }
            }
            Console.WriteLine("Prime Numbers Count " + primeNumbers.Count);
        }
        public void Palindrome()
        {
            Console.WriteLine("Prime Number with palindrome");
            foreach (var data in primeNumbers)
            {
                int sum = 0;
                int number = data;
                while (number > 0)
                {
                    int a = number % 10;
                    sum = (sum * 10) + a;
                    number = number / 10;
                }
                if (data == sum)
                {
                    palindrome.Add(data);
                    Console.WriteLine(data);
                }
            }
        }
        public void Anagram()
        {
            Console.WriteLine("The numbers with prime, palindrome And Anagram Are");
            int[] array = new int[palindrome.Count];
            for (int i = 0; i < palindrome.Count; i++)
            {
                foreach (var data in palindrome)
                {
                    array[i] = data;
                    i++;

                }
            }
            for (int i = 0; i < palindrome.Count; i++)
            {
                for(int j=i+1;j<palindrome.Count;j++)
                {
                    char[] array1 = array[i].ToString().ToCharArray();
                    char[] array2 = array[j].ToString().ToCharArray();
                    Array.Sort(array1);
                    Array.Sort(array2);
                    int Count = 0;
                    if (array1.Length == array2.Length)
                    {
                        for (int k = 0; k < array1.Length; k++)
                        {
                            if (array1[k] == array2[k])
                            {
                                Count++;
                            }
                        }

                    }
                    if (Count == array1.Length)
                    {
                        Console.WriteLine("The Anagram Numbers Are " + array[i] + " " + array[j]);
                    }
                }
            }
        }
    }
}