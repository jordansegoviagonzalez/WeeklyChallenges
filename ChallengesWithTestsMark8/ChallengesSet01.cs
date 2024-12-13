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
            //This method takes two integers as input (number1, and number2)
            // and returns the smaller of the two.
            if (number1 < number2)
            // if :statement that allows to execute different code blocks based on a specific condition, it provides a way to make decisions within your program.
            // Compares the two numbers and returns the smaller one
            {
                
                return number1;
                // if number 1 is smaller, return it, (keyword "return")
                
            }

            return number2;
            // else or otherwise, number 2 is smaller, return it 
            

        }
        public long Multiply(long factor1, long factor2)
            // This Method multiplies two long integer values.
           // public: access modifier: this means the method is accessible from anywhere within the program.
           // long: return type: this part declares that the method is public and returns a long value.
           // Multiply: this is the name of the method, indicating its purpose.
           // parameter name : factor1
           // parameter name : factor2
        { // Methods Body.
            return factor1 * factor2; // this line multiples the two inputs values, factor1, and factor2
            // return statement tells the method to stop executing and send the value stored in the result
            // keyword "return".
            
        }

        public string GetGreeting(string nameOfPerson)
            //This Method returns a greeting message back to the user.
            // public : access modifier, this specifies the visibility of the method, means the method can be accessed from other classes.
            // string : return type, this indicates that the method will return a value of type "string"
            // GetGreeting : methods name, its convention in C# to use PascalCase for  methods names
            // (string nameOfPerson): parameters, this is the input that the method will use to generate a greeting.
        {
            // Methods Body
            if (nameOfPerson == "")
                // Checks if the name is empty
                return "Hello";
                // if the name is empty, returns a generic greetin g
            
            else
            {
                return $"Hello, {nameOfPerson}!";
                // if the name is not empty, returns a personalized greeting
            }
            
            
            
        }
        public string GetHey()
            // public : access modifier, this also mean that only accessible within its own class
            // string : return type, its purpose is to indicate what the method will return.
            // GetHey() : is the methods name implementing PascalCase, its naming convention for methods.
            
        {
            return "Hey!";
            // return :return keyword signals that the method should stop executing and return the specified value.
            // "Hey!"  will be sent back to the caller.
;
        }
    }
}
