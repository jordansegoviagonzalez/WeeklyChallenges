using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            // 'startNumber / n' gives how many times n fits into startNumber (integer division)
            // '+ 1' ensures we get the *next* number divisible by n (not the current one)
            // '* n' gives the actual next divisible number
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            // Loop through each business in the array
            for (int i = 0; i < businesses.Length; i++)
            {
                // If TotalRevenue is 0, change name to "CLOSED"
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            // If array is null or empty, return false
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            // Loop from second element to end
            for (int i = 1; i < numbers.Length; i++)
            {
                // If current number is less than previous, not ascending
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            // If no violations found, return true
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            // Return 0 for null or empty array
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            // Start at second element and check if previous was even
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            // Return empty string for null or empty array
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            // Add trimmed words with a space if not empty
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    sentence += word.Trim() + " ";
                }
            }

            // If sentence still empty, return empty
            if (sentence.Length == 0)
            {
                return "";
            }

            // Remove final space and add period
            sentence = sentence.Substring(0, sentence.Length - 1);
            sentence += ".";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            // Return empty array if list is null or empty
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourth = new List<double>();

            // Start from index 3 (4th element), step by 4
            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }

            // Convert list to array and return
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            // Check all pairs of elements
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    // If pair sums to target, return true
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            // If no valid pair found, return false
            return false;
        }
    }
}
