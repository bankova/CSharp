﻿//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrintWordsAlphabetically
{
    static void Main()
    {
        string input = "tralala alabala portokala koj izyade kashkavala";
        string[] words = input.Split(' ');
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

