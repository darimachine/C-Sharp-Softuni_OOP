using System;
using System.Collections.Generic;
using System.IO;

namespace zad28
{
    
    class Program
    {
        static bool Contains(char[][] words, string word)
        {
            var revword = word.ToCharArray();
            Array.Reverse(revword);
            
            if (Check(words, word) || Check(words, new string(revword)))
            {
                return true;
            }
            return false;
        }
        static bool Check(char[][] words, string word)
        {
            int counter = 0;
            int k = 0;
            for (int i = 0; i < words.GetLength(0); i++)
            {
                if (word.Length > words[i].Length)
                {
                    return false;
                }
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (word[k] == words[i][j])
                    {
                        
                        counter++;
                        k++;
                        if (counter == word.Length)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (words[i].Length - j - 1 < word.Length)
                        {
                            break;
                        }
                        
                    }
                }
                
                counter = 0;
                k = 0;
            }

            return false;
        }
        static char[][] ReadMatrix(string filename)
        {
            using StreamReader reader = new StreamReader(filename);
            List<char[]> array = new List<char[]>();
            int i = 0;
            var line = reader.ReadLine();
            array.Add(line.ToCharArray());
            while (!reader.EndOfStream)
            {
                
                
                line = reader.ReadLine();
                if (array[i].Length != line.Length)
                {
                    return null;
                }
                array.Add(line.ToCharArray());
                i++;

            }
            return array.ToArray();
        }
        static void Main(string[] args)
        {
            char[][] array = ReadMatrix("table.txt");
            string word = "test";
            string word1 = "dac";
            string word2 = "ama";
            string word3 = "ama";
            string word4 = "TDA";



            Console.WriteLine(Contains(array,word));
            Console.WriteLine(Contains(array, word1));
            Console.WriteLine(Contains(array, word2));
            Console.WriteLine(Contains(array, word3));
            Console.WriteLine(Contains(array, word4));

        }
    }
}
