using System;
using System.Collections.Generic;
// 'using System;' gives us access to basic classes and types like Console. Math, and arrays.
using System.Linq;
// 'using Sytem.Linq; gives us access to helpful methods like 'Where()' and 'Sum()' for working with collections like arrays and lists.

namespace ChallengesWithTestsMark8
//'namespace' groups related code together. This is where out class and method live.
{

    public class ChallengesSet04
    //'publiuc class ChallengesSet04' defines a class name 'ChallengesSet04'.
    //'public' makes this class accessible from other parts of the program.
    {
       //Below up on inspection we have a method and its purpose is to add all even numbers,
       //subtract all odd numbers, and return the result.     
        public int AddEvenSubtractOdd(int[] numbers)
        //'public' means this method can be used from outside this class.
        // 'int' means this method will return and int (whole number).
        // 'AddEvenSubtractOdd' is the name of the method. It follows PascaleCase naming.
        //'(int[]numbers)' is a parameter it takes an array of ints called 'numbers'.
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
            //'numbers.Where(x => x % 2 == 0).Sum()' finds all even numbers in the array and adds them up.
            //'numbers.Where(x => x % 2 !=0).Sum()' finds all odds numbers and adds them up.
            // Then, the methods subtracts the sum of odd numbers from the sum of even numbers.
            //The result is returned as the output of this method.
        }
        
        //Bellow we have a method and its purpose is to find the lenght of the shortest string among four give strings.    
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        //'public' makes this method accessible from outside the class.
        //'int' means this method returns an int value.
        //'GetLenghtOfShortestString' is the name of the method written in PascalCase.
        //'(string str1, string str2, string str3, string str4)' are the parameters. These are the four strings being compared.
        
        
        {
            var list = new List<int> {str1.Length, str2.Length, str3.Length, str4.Length};
            //'var list' declares a list of int.
            //The list stores the lenght of each input string uysing the '.Lenght' property.
            
            return list.Min();
            // 'list.Min()' finds and returns the smallest number (shortest lenght) from the list.
        }

        //Bellow up inspection we have a method and its purpose is to  return the smallest numbers
        // out of the four given ints inputs.
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> {number1, number2, number3, number4};
            //'var list' declares a new list of ints.
            // 'new List<int>' creates a list that holds tha four input numbers.
            //'{number1, number2, numbers3, number4,}' adds each number to the list.
            return list.Min();
            //'list.Min()' finds and returns the smallest number from list.
        }
        //Below upon inspection we have a method and its purpose is to change the name of a giving Business object to "TrueCoders"
        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        // 'public' means this method can be accessed from outside this class.
        //'void' means this method does not return any value(it just performs an action).
        //'ChangeBusinessNameTo_TrueCoders' is the method name, following PascalCase naming convention.
        //'(Business biz)' is the parameter it takes a Business object called 'biz'.
        
        {
            biz.Name = "TrueCoders";
            // 'biz.Name' accesses the 'Name' property of the Business object passed in.ss
            //'="Truecoders";' assigns the string "TrueCoders" to the Name property of the 'biz' object.
        }
        
        //Below we have a method and its purpose is to determine if the 
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
            // 'public' means this method can be accessed from outside this class.
            // 'bool' means this method will return a boolean value (true or false).
            // 'CouldFormTriangle' is the method's name, following PascalCase naming convention.
            // '(int sideLength1, int sideLength2, int sideLength3)' are the parameters representing the lengths of the sides of a triangle.
        {
            return ( sideLength1 + sideLength2 > sideLength3 && 
                     sideLength1 + sideLength3 > sideLength2 && 
                     sideLength2 + sideLength3 > sideLength1
                );
            // The method checks three conditions to determine if the given side lengths can form a triangle:
            // - 'sideLength1 + sideLength2 > sideLength3' checks if the sum of the first two sides is greater than the third side.
            // - 'sideLength1 + sideLength3 > sideLength2' checks if the sum of the first and third sides is greater than the second side.
            // - 'sideLength2 + sideLength3 > sideLength1' checks if the sum of the second and third sides is greater than the first side.
            // If all these conditions are true, it returns true, indicating that a triangle can be formed. Otherwise, it returns false.
        }
        
        // Below we encounter a method and its purpose is to check if the given stgring can be converted into a  number.
        public bool IsStringANumber(string input)
        //'public' means this method can be accessed from outside the class.
        //'bool' means the method returns a bool value - true or false.
        //'IsStringANumber' is the name of the method. It follows PascalCase naming.
        //'(string input)' is the parameter, it takes a string called 'input'.
        {
            var isNumber = double.TryParse(input, out double number);
            //'var isNumber' declares a variable that will hold the result of the TryParse method.
            //'double.TryParse(input, out double number)' tries to convert the input string into a double.
            //If it can be converted, 'isNumber' is true and the converted number is stored in 'number'.
            //If it can't be converted, 'isNumber' is false.
            
            return isNumber;
            //Return true if the input was a number, otherwise return false.
        }
        
        //Below we have a method and its purpose is to check if the majority of the elements in the array are null.
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //'public' means this mehtod can be accessed from outside the class.
            //'bool' means this method returns a bool value true or fasle.
            //'MajorityOfElementsInArrayAreNull' is the name of the method, written in PascalCase.
            //'(object[] objs)' is the parameter - it takes an array of objects called 'objs'
            var amount = objs.Length;
            //'var amount' declares a variable to store the total number of elements in the array.
            //object.Lenght' get the total count of items in teh 'objs' array.
            var majority = (amount / 2) + 1;
            //'var majority' calculates the number of elements needed to make up more than half the array.
            //It adds 1 to half the total to get the majority.
            
            var count = 0;
            //'var count' declares a counter to track how many elements in the array are null.
            

            foreach (var obj in objs)
            {
                // 'foreach' loop though every element in the 'objs' array.
                //'var obj' represent each item in the array during each loop cycle.
                if (obj == null)
                {
                    count++;
                    //If the current object is null, increase the 'count' by 1.
                }
                
            }

            if (count >= majority)
            {
                return true;
                //if the numbers of null elements is equal to or greater than majority,
                //return true - meaning the majority of elements are null.

            }
            else
            {
                return false;
                //Otherwise, return false - majority of elements are not null.
            }
        }
        
        // Below upon inspection we have a method and its purpose is to calculate and return the average of all even numbers in the array.
        // if the array is null of there are no even numbers, its returns 0.
        public double AverageEvens(int[] numbers)
        //'public' means this method can be accessed from outside the class.
        //'double' means this method returns decimal numbers.
        //'AverageEvens' is the name of the method written in PascalCase.
        //'(int[]numbers)' is the parameter it takes an array of ints called 'numbers'
        
        {
            double sum = 0;
            //'double' declares double variable name 'sum' to store the total of even number.
             
            double count = 0;
            //'double' declares a double varibale name 'count' to keep track of how many even numbers are found.
            
            
            //Below we have an if statment 
            if (numbers == null)
                
            {
                return 0;
                //Cheks if the input array is null.if it is, return 0 

            }
            
            //Donw here we have a forach each loop
            foreach (var num in numbers)
                // loops though each numebrs in the 'number' array.
               // 'var num' represent each number in the loop.
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    //Adds the even number to the 'sum'
                    count++;
                    // Increase the 'count' by 1 for each even number.
                }
            }

            if (count > 0)
            {
                return sum / count;
                //If there are even numbers, calculate and return the average by dividing the sum by the count.
                
            }
            else
            {
                return 0;
                //If no even numbers were found, return 0.
            }
        }
        
        
        // Below up inspection we havve a method and its purpose is to calculate and return
        //the factorial of a givin number. If the input number is 0, it thows an exception.
        public int Factorial(int number)
        //'public' means this method can be accessed from other classes.
        //'int' means this method will return an int result.
        //'Factorial' is the name of the method, using PascalCase.
        //'(int numbers)' is a parameter it takes one int called 'number'
        {
            var fact = 1;
            //'var fact = 1' initializes a variable called 'fact' to hold the result of the factorial.
            // We start it at 1 because multiplying by 1 dose not change the value.
            
            if (number < 0)
                //if statement will check numbers
            {
                throw new ArgumentOutOfRangeException();
                //If the int is 0, this line throws an exception because factorial of 0 is not allowed here.
                //'thow' is a keyword that stops the method and signal and error.
                //'new' is used to creat a new instance of an oject.
                //'ArgumentOutOfRangeExceptio();' is a specific build in exeption class.
                //There are not one single funstion they work together to create and thow an erro.
                //If this case we are thwoing a new ArgumnetOutOfRangeExeption();
            }

            for (int i = number; i > 0; i--)
                // This is a for loop that repeats a block of code a certain number of times.
                // 'int i = number' initializes the counter variable 'i' with the value of 'number'.
                // 'i > 0' is the condition that keeps the loop running as long as 'i' is greater than 0.
                // 'i--' decreases 'i' by 1 after each iteration of the loop (decrementing).
                // The loop continues to run until 'i' is no longer greater than 0.

            {
                fact *= i;
                //This multiplies the current value of 'fact' by the current value of 'i'
                // it's the same writing 'fact = fact * i'
                // For example: if number is 4, it will do 1 * 1, then 1 * 2, then 2 * 3, then 6 * 4 = 24.
            }
            return fact;
            //After the loop finished, this returns the final result the final result of the factorial.
        }
    }
}
