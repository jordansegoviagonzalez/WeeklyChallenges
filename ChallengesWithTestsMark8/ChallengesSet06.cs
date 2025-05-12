using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        // Checks if the provided word exists in the collection of words.
        
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            // Return false if the input collection is null or contains null values.
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase)
            {
                // Convert all strings in the collection and the target word to lowercase for comparison.
                word = word.ToLower();
                List<string> lowerCaseWords = words.Select(x => x.ToLower()).ToList();
                containsWord = lowerCaseWords.Contains(word);
            }
            else
            {
                // Case sensitive search.
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        // Determines whether the given number is a prime number.
        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;

            // Check if number is not divisible by 2 or 3.
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }

            // Handle special cases: 2 and 3 are prime numbers.
            if (num == 2 || num == 3)
            {
                isPrime = true;
            }

            // 1 is not a prime number.
            if (num == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }

        // Returns the index of the last unique character in the string.
        // Returns -1 if no unique character exists.
        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool isUnique;

            // Loop through each character in the string.
            for (int i = 0; i < str.Length; i++)
            {
                isUnique = true;

                // Check for duplicates of the current character.
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }

                // Update index if a unique character is found.
                if (isUnique)
                {
                    index = i;
                }
            }

            return index;
        }

        // Returns the maximum count of consecutive identical numbers in an array.
        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 0;

            // Iterate through each number in the array.
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                // Count how many times the current number repeats consecutively.
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                // Update the maximum count if the current streak is longer.
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }

            return maxCount;
        }

        // Returns every element in the list that is divisible by n.
        // Returns an empty array if the input list is null or if n is invalid.
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] emptyArray = new double[0];

            // Return empty array if elements list is null.
            if (elements == null)
            {
                return emptyArray;
            }

            // Loop through each element and check if it is divisible by n.
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }

                // Clear list if n is less than 0 or greater than the list size.
                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }

            return nthElement.ToArray();
        }
    }
}

