using System;
// "System" provides basic functionality like console output and built in type such as 'int' and 'char'.
using System.Collections.Generic;
// "System.Collection.Generic" provides types like List<T> and other collection-related fu
using System.Linq;

namespace ChallengesWithTestsMark8
// This is the namespace, a way to ground related classes together.
// Think of is as namespace as a folder, and ChallangesWithTestsMark8 is the tittle of the folder.

{
    public class ChallengesSet02
        // 'public class ChallengesSet02' is a declaration of a class.    
        // 'public' is the access modifier that makes the class accessible from anywhere in the program.
        // 'class' is used to define a blueprint for creating objects; it encapsulates data (fields) and behavior (methods).
        // 'ChallengesSet02' (in PascalCase) is the name of the class.
    {
        public bool CharacterIsALetter(char c)
            // 1. This method checks if a given character is a letter.    
            // 'public' is the access modifier that makes the method accessible from anywhere in the program.
            // 'bool' is the return type, indicating the method return a bool value (true or false).
            // 'CharacterIsAletter' (in PascalCase) is the name of the method.
            // 'char c' is the parameter of type 'char', representing a single charter input to be checked.
        {
            return char.IsLetter(c);
            // 'return' is a keyword that send the result of the following expression back to the method's caller.
            // 'char.IsLetter(c)' is a built-in static method of the 'char' class in C#. 
            // - it checks if the character 'c' is a letter (A-Z or a-z).
            // - it returns a bool value ('true' if 'c' is a letter, 'false' if it is not).
            // 'char' is a data type in C# that holds a single character, and 'IsLetter' is a method int the 'char'.
            // - that performs the check.
            // The result of 'char.IsLetter (c)' (true or false) is immediately returned by the method.
        }

        public bool CountOfElementsIsEven(string[] vals)
            // 2. This Method checks if the number of elements in an array is even.    
            // 'public' is the access modifiers that makes the method accessible from anywhere in the program.
            // 'bool' is the return type, indicating the method will return a true or false value.
            // 'Count0fElementsIsEven' (in PascalCase) is the name of the method.
            // 'string[] vals' is the parameter, an array of strings that the method will process.
        {
            if (vals.Length % 2 == 0)
                // 'if' is a control structure used to execute block of code if a condition is true.
                // The Condition being checked is 'vals.Length % 2 == 0'
                // 'vals.Lenght' gets the total number of elements in the array 'vals'.
                // '% 2' computes the remainder when the arrays lenght is divided by 2.
                // if the remainder is 0 (i.e., the lenght is an even number), the condition evaluates to true.
                // if the array lenght is even, it enters this block and returns true.
            {
                return true;
                // 'return' is a keyword that send the result of the following expression back to the method's caller.
                // 'true' is a bool literal indicating that the condition (even number of elements) is satisfied.
            }
            else
                // 'else' is used to specify an alternative block of code to execute when the 'if' condition is false.
            {
                return false;
                // 'return' send the result of the following expressing back to the caller.
                // 'false' is a boolean literal indicating that the condition (even number of elements) is not satisfied.
                // in other words returns 'false' because the lenght of the array is odd.
            }
        }

        public bool IsNumberEven(int number)
            // 3. This Method to checks if a number is even.
            // 'public' is the access modifier that makes the method accessible from anywhere in the program.
            // 'bool' is the return type, indicating the method will return a bool value (true or false).
            // 'IsNumberEven' (in PascalCase) is the name of the method.
            // 'int number' is the parameter, representing an int that will be checked if it's even.
        {
            if (number % 2 == 0)
                // if the number is divisible by 2 (even number),
                // we return true because the number is even.
                // 'number % 2' is a modulo operation that calculates the remainder of the division.
                // if the remainder is zero ('number % 2 == 0'), it means the number is even.
            {
                return true;
                // 'return' is a keyword that sends the result of the following expression back to the method's caller.
                // 'true' is a bool literal indicating that the number satisfies the condition of being even.
            }
            else
                return false;
            // 'return' sends the result of the following expressiong back to the caller.
            // 'false' is a bool literal indicating that the number does not satisfy the condition of being even. 
        }

        public bool IsNumberOdd(int num)
            // 4. This method checks if a given number is odd.
            // 'public' is the access modifier that makes the method accessible from anywhere in the program.
            // - It allows this method to be accessed from other classes or components.
            // 'bool' is the return type, indicating the method returns a bool value (true or false).
            // 'IsNumberOdd' (in PascalCase) is the name of the method.
            // keypoint the name clearly describes the method’s purpose: checking if a number is odd.
            // 'int num' is the parameter representing a single integer value to be checked.
            // - 'num' is the input provided to the method that will be evaluated for oddness.
        {
            if (num % 2 != 0)
                // If the number is not divisible by 2 (odd number),
                // The condition evaluates to true because the remainder is not zero.
            {
                return true;
                // Returns 'true' because the condition confirms the number is odd.
            }
            else
                // If the number is divisible by 2 (even number),
                // The condition evaluates to false because the remainder is zero.
            {
                return false;
                // Returns 'false' because the number is even.
            }
        }


        public double SumOfMinAndMax(IEnumerable<double> numbers)
            // 5. This method calculates the sum of the smallest and largest number in a collection.
            // 'public' is the access modifier, making the method accessible from anywhere in the program.
            // 'double' is the return type, indicating the method will return a number with decimals.
            // 'SumOfMinAndMax' (in PascalCase) is the name of the method.
            // 'IEnumerable<double> numbers' is the parameter, representing a collection of numbers to process.
        {
            if (numbers == null)
                // 'if' checks whether the 'numbers' collection is null (no data provided).
                // If 'numbers' is null, the method returns 0 as a safeguard to avoid errors.
            {
                return 0;
                // 'return' sends 0 back to the method's caller, indicating there's no valid input.
            }

            if (numbers.Count() == 0)
                // 'if' condition checks if the 'numbers' collection is empty by evaluating its count.
                // 'numbers.Count()' gets the total number of items in the collection.
                // If there are no elements, the method returns 0.
            {
                return 0;
                // 'return' sends 0 back to the caller, as there's no data to calculate from.
            }

            return numbers.Min() + numbers.Max();
            // 'numbers.Min()' gets the smallest number in the collection.
            // 'numbers.Max()' gets the largest number in the collection.
            // The result of 'numbers.Min() + numbers.Max()' is the sum of these two values.
            // 'return' sends this sum back to the method's caller.
        }


        public int GetLengthOfShortestString(string str1, string str2)
            // 6. This method returns the length of the shorter string between two given strings.
            // 'public' is the access modifier, making the method accesible from anywhere in the program.
            // 'int' is the return type, indicating the method will return and int.
            // 'GetLengthOfShortestString' (in PascalCase) is the name of the method.
            // 'string str1, string str2' are the parameters, representing two string to compare.
        {
            if (str1.Length < str2.Length)
                // 'if' check wheter the lenght of 'str1' is less than the lenght of 'str2'.
                // If 'str1' is shorter, it will return the lenght of 'str1'.

            {
                return str1.Length;
                // 'return' sends the lengh of 'str1' back to the method's caller if it's the shorter string.
            }
            else
            {
                return str2.Length;
                // 'return' sends the lenght of 'str1' back to the method's caller if it's the shorter string.
            }
        }

        public int Sum(int[] numbers)
            // 7. This method calculates the sumof all numbers in an array.
            // 'public' is the access modifier, making the method accessible from anywhere in the program.
            // 'int' is the return type, indicating the method will return an int value.
            // 'Sum' (in PascalCase) is the name of the methods.
            // 'int[] numbers' is the parameter, representing an array of int to sum up.
        {
            if (numbers == null)
                // 'if' checks the 'numbers' array is null (no data provided).
                // If 'number' is null, the method return 0 to avoid errors.
            {
                return 0;
                // 'return' send 0 back to the method's caller, indicating no valid input to sum.
            }

            var sum = 0;
            // 'sum' is a variable initialized to 0, used to accumulate the sum of the array elements.

            for (int i = 0; i < numbers.Length; i++)
                // 'for' loop goes through each number in the 'numbers' array, one at a time.
                // 'i' represents the index of the current element, starting from 0.
                // The loop continues until all elements in the array have beeg processed.
            {
                sum += numbers[i];
                // 'sum += numbers[i]' adds the value of the current element to the 'sum' variable.
            }

            return sum;
            // 'return' sends the final sum of all elements in the array back to the method's caller.
        }

        public int SumEvens(int[] numbers)
            // 8. This method calculates the sum of only even numbers in an array. 
            // 'public' allows the method to be accessed from anywhere in the program.
            // 'int' is the return type, meaning the method will return an integer.
            // 'SumEvens' is the method's name;
            // 'int[] numbers' is the parameter, representing an array of integers to process.

        {
            if (numbers == null)
                // 'if' checks 'numbers' is null (no data provided).
                // If 'numbers' is null, the method returns 0 to avoid errors.
            {
                return 0;
                // 'return' sends 0 back to the caller, indicating no valid input.
            }

            var evenSum = 0;
            // Initializes a variable called 'evenSum' to store the total sum of even numbers.

            for (int i = 0; i < numbers.Length; i++)
                // 'for' loop goes through each element in the 'numbers' array.
                // Starts at the first index and moves to the next one until the end of the array.
            {
                if (numbers[i] % 2 == 0)
                    // 'if' checks the current number is even (i.e., divisible by 2 without a remainder).
                {
                    evenSum += numbers[i];
                    // Adds the current even number to 'evenSum'.
                }
            }

            return evenSum;
            // 'return evenSum' sends the calculated sum of even numbers back to the caller.
        }

        public bool IsSumOdd(List<int> numbers)
            // 9. This method checks if the sum of the numbers in a list is odd, keyword 'IsSumOdd'.
            // 'public' allows the method to be accessed from anywhere in the program.
            // 'bool' is the return type, meaning the method will return a bool value (true or false)
            // 'IsSumOdd' is the method's name, indicating that it cheks if the sum is odd.
            // 'List<int> number' is the parameter, representing a list of int to sum.

        {
            if (numbers == null)
                // 'if' checks if 'number' is null (no data provided).
                // if 'number' is null, the method returns false to avoid errors.
            {
                return false;
                // 'return' send false back to the caller, indicating no valid input
            }

            return (numbers.Sum() % 2 != 0);
            // 'numbers.Sum()' calculates the sum of all numbers in the list.
            // The modulos operator checks if the sum is divisible by 2 (i.e., even or odd).
            // If the result of 'numbers.Sum() % 2' is not equal to 0, the sum is odd, and the method returns true.
            // Otherwise, it returns false, indicating the sum is even.
        }

        public long CountOfPositiveOddsBelowNumber(long number)
            // 10. This method counts how many positive odd numbers are below a given number.
        // keyword and name of this method is CountOfPositionOddsBelowNumber.
        // 'long' is the return type, meaning the method will return a long value (a whole number).
        // 'CountOfPositiveOddBelowNumber' is the method's name, indicating that it counts positive odd numbers bellow a giving number.
        
        {
            if (number <= 0)
                // 'if' chekcs if the number is less than or equal to 0.
            // if the number is less than or equal to 0, it returns 0, indicating no positive odd numbers below 0.
            {
                return 0;
                // 'return' sends 0 back to the caller, indicating no positive odd numbers below 0.
            }
            else
            // 'else' executes when the number is greater than 0.
            {
                return number / 2;
                // It calculates how many positive odd numbers are below the given numer.
                // Dividing the number by 2 gives the count of positive odd numbers below the number, because odd numbers alternate with even numbers.
            }
        }
    }
}

