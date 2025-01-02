using System;
// "System" provides basic functionality like console output and built in type such as 'int' and 'char'.
using System.Collections.Generic;
// "System.Collection.Generic" provides types like List<T> and other collection-related fu

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
        // 'bool' is the return type, indicating the method return a boolean value (true or false).
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
                // 'return' is a keyword that send the result of the folloeing expression back to the method's caller.
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
                // if the number is divisible by 2 (even number)
           
            
        }

        public bool IsNumberOdd(int num)
        // 4. Method check if a number is odd.
        // 'public' is the access modifier that makes the method accessible from anywhere in the program.
        // 'bool' is the return type, indicating the method will return a boolean value (true or false).
        // 'IsNumberOdd' (in PascalCase) is the name of the method.
        // 'int num' is the parameter, representing the int to check if it's odd.
        
        {
            return num % 2 != 0;
            // 'return' is a keyword that sends the result of the following expression back to the method,s caller.
            // 'num' refers to the int passed to the method.
            // '%' is the modulus operator, which calculates the remainder when 'num' is divided by 2.
            // '!=0' check if remainder is not zero, meaning the number is not divisible by 2 (odd).
            // The expression 'num % 2 !=0' evaluates the 'true' if the number is odd, otherwise 'false'.
            // The result of this evaluation (true or false) is immediately returned by the method.
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
