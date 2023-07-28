﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
                if(data ==sum)
                {
                    palindrome.Add(data);
                    Console.WriteLine(data);
                }       
            }
        }   
        public void Anagram()
        {
            foreach (var data in primeNumbers)
            {
                
            }
        }
    }
}