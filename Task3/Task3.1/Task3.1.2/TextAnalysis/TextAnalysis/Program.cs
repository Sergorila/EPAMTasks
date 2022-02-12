using System;
using System.Collections;
using System.Collections.Generic;
using TextAnalysis.Analysis;

namespace TextAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your text: ");
            string s = Console.ReadLine();
            Text text = new Text(s);
            Console.WriteLine("The list of words and their percentage of their appearance: ");
            text.ShowStatistics();
            Console.WriteLine();
            text.GiveAnswer();
        }
    }
}
