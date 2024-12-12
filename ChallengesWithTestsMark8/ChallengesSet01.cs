using System;

namespace ChallengesWithTestsMark8
{
    public   class ChallengesSet01
    { 
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
             return minuend - subtrahend; 
        }

        public int Add(int number1, int number2)
        {
          return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            // public : Makes this method available to use anywhere in the program.
    
            // int : The method will return an integer value (the smaller number).
    
            // GetSmallestNumber : The method name. It tells you that the method finds the smallest number.
    
            // (int number1, int number2) : These are the inputs (two numbers) you provide when calling the method. 
            // These are the numbers being compared to find the smallest.
    
            //  return : Sends the result (the smallest number) back to where the method was called. It ends the method.
    
            // Math Math:is the Class that contains mathematical functions constants.
            
            // Min() (a method that returns the smaller of the two numbers).
            
            // Math.Min(number1, number2): This compares number1 and number2 and returns the smaller number.
            
            return Math.Min(number1, number2);  
            
            // It compares number1 and number2, then returns the smaller value.
            // number1 and number2 are the arguments (inputs) giving to Math.Min, which are the two numbers being compared.
        }
        public long Multiply(long factor1, long factor2)
           //This Method adds two integers values and returns the result.
           // Multiply is the names method
           // parameter name : factor1
           // parameter name : factor2
        {
            return fartor1 * factor2;
            // return statement tells the method to stop executing and send the value stored in the result 
            
        }
        // public : access modifier, this specifies the visibility of the method, means the method can be accessed from other classes.
        // string : return type, this indicates that the method will return a value of type "string"
        // GetaGreeting: methods name, its 
     
        //

        public string GetGreeting(string nameOfPerson)
            // public : access modifier, this specifies the visibility of the method, means the meothod can be accessed from other classes.
            // string : return type, this indicates that the method will rerurn a value of type "string"
            // GetaGreetping: methods name, its convention in C# to use PascalCase for  methods names, 
            // (string nameOfPerson): parameters, this is the input that the method will use to generate a greeting.
        {
            return $"Hello {nameOfPerson}!";
            // return: specifies the return value that the method should send back.     
        }
        public string GetHey()
            // public : acces modifier, this also mean that only accessible within its own class
            // string : return type, its purpuse is to indicate what the method wuill return.
            // GetHey() : is the methods name inplementing PascalCase, its naming convention for methods.
            
        {
            return "Hey!";
            // ret1urn :return keyword signals that the method should stop executing and return the specified value.
            // "Hey!" : will be sent back to the caller.
;
        }
    }
}
