using System;
using System.Collections.Generic;

namespace CodingChallenge2
{
    public class CharandCount
    {
        public char Character { get; set; }
        public int Count { get; set; }

        public CharandCount(char character, int count)
        {
            Character = character;
            Count = count;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = "She sells seashells by the seashore.";
            char[] input = inputString.ToCharArray();

            List<CharandCount> charCounts = new List<CharandCount>();
            charCounts.Add(new CharandCount(Char.ToLower(input[0]), 1));

            for (int i = 1; i < input.Length; i++)
            {
                bool charInList = false;
                foreach (CharandCount charAndCount in charCounts)
                {
                    if (Char.ToLower(input[i]).Equals(charAndCount.Character))
                    {
                        charInList = true;
                        charAndCount.Count++;
                    }
                }
                if (!charInList)
                    charCounts.Add(new CharandCount(Char.ToLower(input[i]), 1));
            }

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<CharandCount> sortedCharCounts = new List<CharandCount>();

            foreach (char letter in alphabet)
            {
                foreach (CharandCount charandCount in charCounts)
                {
                    if (letter.Equals(charandCount.Character))
                        sortedCharCounts.Add(charandCount);
                }
            }

            foreach (CharandCount charandCount in sortedCharCounts)
            {
                Console.WriteLine(charandCount.Character + ": " + charandCount.Count);
            }
            Console.ReadLine();
        }
    }

}
