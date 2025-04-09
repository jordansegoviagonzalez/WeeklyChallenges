using System;
//Gives access to basic funtionality like data types, Console, etc.
using System.Collections.Generic;
//Allows use of generic collection list<T>, Dictionary<Tkey,TValue, etc. 
using System.Linq;
//Provides LINQ (Language Integrated Query) Methods like .Constains(), .Where(), etc.

namespace ChallengesWithTestsMark8
//Declarers a namespace called 'ChallengesWithTestMark8' to organize related classes.

{
    public class ChallengesSet03
    //'public' makes this class accessible from other files or projects.
    //'class' defines a blueprint for creating a objects or grouping related methods.
    //'ChallengesSet03' is the name of the class.
    {
        public bool ArrayContainsAFalse(bool[] vals)
        //'public' allows this method to be accessed from another classes.
        //'bool' is the return type, meaning this method returns true or false.
        //'ArrayContainsAfalse' is the method name - itr checks if the array has any 'false' value.
        //'bool[] vals' is a parameter; an array of boolean values that this method checks.
        {
            for (int i = 0; i < vals.Length; i++) 
                //'for' loop is used to iterate (Go through each element, one by one.) thought each index of the array.
            //'int i = 0' initializes the counter variable i to start at 0.
            //'i < vals.leight' cotinues looping by after each loop.
            //'i++' increments the counter by 1 after each loop.

            {
                if (vals[i] == false)
                    //'if' checks a condition it asks is the current value in the arrya at index 1 euqal to true
                //'vals[i]' accesses the element at the index i in the array.
                {
                    return  true;
                    //'return' ends the method and send back a result.
                    // This line back 'true' iuf a value in the array is true.
                    
                }
            }
            
            return false;
            //if the loop finished and no 'true' value were found, this line runs.
            //'return false' me ans thge array did not cotain any 'true' values all were false.
        }

        //Below, up on inspection, we have a method called IsSumOfOddsOdd(in Pascal casing).
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        //'public' allows this method to be accessed from outside the class or program.
        //'bool' inidicates that the method will return a bool value (true, or false.)
        //'IsSumOfOddsOdd' is the name of the method in Pascal casing, which suggest it checks if the sum of odd numbers is odd.
        //'IEnumerable<int>' is the parameter that represents a collection of ints (the numbers to be processed).
        {
            if (numbers == null || numbers.Count() == 0)
                //'if' checks if the given condition is true.
            //'numbers == null' checks if the input collection is null.
            //'numbers.Count() == 0' checks if the collection has no elements.
            //If either of these conditions is true, the method will return 'false', indicating an invalid input.
            {
                return false;
                //'return false' exist the method and returns the value 'false' if the input is invalid(null or empty)
            }

            var sum = numbers.Sum();
            //'var' allows implicit typing, lettting the compiler determine the type of 'sum'.
            //'numbers.Sum()' calculates the sum of all elements in the 'numbers' collection.

            return (sum % 2 != 0);
            //'return' is used tp exist the method and provide the results of the condition to the caller.
            //The condition 'sum % 2 != 0' checks if the sum of the numbers is odd.
            //'sum % 2' calculates the remainder when 'sum' is divided by 2.
            //If the remainder is not 0 ('i=0'), this indicates that the sum is odd.
            //The method will return 'true' if the sum is odd(because the remainder is not 0),
            // and 'false' if the sum is even (because the remainder is 0).
            
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        //'public' make the method accessible from outside the class.
        //'bool' means this method returns a bool value: either true or false.
        //'PasswordContainsUpperLowerAndNumber' is the name of the method, written in PascalCase.
        //'(string password)' is the input parameter. it's the password we want to analyze.
        {
            var isLower = false;
            //'var' lets the compiler decide the type based on what we assing - here its a bool.
            //'isLower' is the name of this variables
            var isUpper = false;
            //Another bool variable, inferred using 'var'
            //'isUpper' will track whether the password contains an uppercase letter.
            // Initially set to  'false' because no upppercase letter has been found yet.
            var isNumber = false;
            // Same as above this varibale will track whether the password contains a new number.
            // Starts as 'false' and will be set to be 'true' once a number is found in the password.

            for (int i = 0; i < password.Length; i++) 
                //'for' loop goes thought each character of the password string.
            //'i' is the loop counter, starting at 0 and continuing until the lenght of the password string is reached.
            //'password.Leght' gives the total numbers of characters in the password
            {
                if (char.IsLower(password[i]))
                    //if checks if the current charadcer is a lowercases letter.
                //If true, 'isLower' is set to true
                {
                    isLower = true;
                }

                if (char.IsUpper(password[i]))
                    //Checks if the current character is an uppercase letter.
                // if true, 'isUpper' is set to true.
                {
                    isUpper = true;
                }

                if (char.IsNumber(password[i]))
                    //Chekcs if the current character is a nunber.
                //If true, 'isNumber' is set to true.
                {
                    isNumber = true;
                }
                
            }

            if (isLower == true && isUpper == true && isNumber == true)
                //After the loop, checks if all three conditions (lowercase, uppercase, and number) are true.
            //If all are true, returns true, meaning the password contains at least one lowercase letter, one uppercase, letter, and one number.
            {
                return true;
            }
            else
            //If any of the conditions is false, return false.
            //This means the password doesn't meet all the required conditions.
            {
                return false;
            }
        }
        
        

        public char GetFirstLetterOfString(string val)
        //public makes the method accessible from outisde the class.
        //char means this method returns a single characeter.
        //'GetFirstLetterOfSpring' is the name of the method, writtin in PascalCase.
        //'(string val)' is the input parameter. Its the string from which we want to extract the first letter.
        {
            return val.First();
            //'val.First()' is a LINQ method that retrieves the first character of the string 'vals'
            //If 'val' is an empty string, it will throw an exception, but otherwise,it returns the first charactger.
        }

        public char GetLastLetterOfString(string val)
        //public make the method accessible from outside the class.
        // char means this method returns a single character.
        //'GetLastLetterOfString' is the name of the method, written in PascalCase.
        //'(streing val)' is the input parameter. Its the string from which we wants extract the last letter.
        {
            return val[val.Length - 1];
            //'val.Lenght - 1' gives the index of the last character in the string (since indices are zero based)
            //'val[val.Lenght - 1]' retrives the characater at that index.
            //This method assumes the string is not empty. If the string is empty, it will throw an IndexOuTOfRangeException.
            
        }

        public decimal Divide(decimal dividend, decimal divisor)
        //public make the method accessible from ouside the class.
        //decimal means this method returns a decimal value, which is a high presision floating point type.
        //Divide is the name of the method, in PascalCase.
        // '(decimal divided, decimal division)' are the input parameters.
        //'divided' is the number to be divided, and 'divisor' is the number by which 'dividend' will  be divided.
        {
            if(divisor == 0)
            {
                return 0;
                //The 'if' statement checks if the division is zero.
                //Division by zero is undefine, so the method returns 0 if 'division' is 0.
                //This is safeguard to prevent a runtimew exeption (DivideByZeroExeption) 
            }

            return dividend / divisor;
            //if the division is not zero, the method return the result of dividing 'divided' by 'divisor'

        }

        public int LastMinusFirst(int[] nums)
        //public make the method accessible from ouside the class.
        // int means this method returns an int value, which is the result of subtracting the first element from the last element of the array.
        //'LastMinusFist' is the name of the method, written in Pascal.
        //'(int[]nums)' is the input parameter, which is an array of the int called 'nums'
        //The array represents a collection of int where the method will subtract the first value from the last one.
        {
            return nums[nums.Length - 1] - nums[0];
            //'num.Lenght - 1' access the last element of the arrat.
            // 'nums[0]' accesses the first element of the array.
            //The method returns the result of substracting the first elemnt from the last element in the array.
        }

        public int[] GetOddsBelow100()
        //public allows this method to be accessed from outside of the classs.
        //int[]' means this method returns an array of int (int[]), containing odd numbers bellow 100.
        //'GetOddsBelow100' is the name of the metho, written in PascalCase.
        //'()' indicatges this method dose not take any parameters.
        {
            var list = new List<int>();
            //'var' allows the compiler to infer the type of the variable 'list' based on its assignment.
            //'list' is a List of int, initialized to store the odd numbers below 100.

            for (int i = 0; i < 100; i++)
                // A for loops runs 100 times, from 0 to 99.
            //'int i' is the loop counter, starting at 0 and increasing by 1 each iteration.
            {
                if(i % 2 != 0)
                    //Checks if 'i' odd (not divisiable by2)
                {
                    list.Add(i);
                    //Add 'i' to the list if it's odd.
                }
            }

            return list.ToArray();
            //Converts the list of odd numbers to an array and returns it.
        }

        public void ChangeAllElementsToUppercase(string[] words)
        //public makes the method accesible from outside the class.
        //'void' indicates that this method dose not return any value.
        //'ChangeAllElementsToUppercase' method  name in Pascal that describes the method's pupose: converting all strings to uppercase.
        
        {
            for (int i = 0; i < words.Length; i++)
                //Begins a 'for' loop that interates over every element in the 'words' array.
            //'int i = 0' initilizez the loop counter at 0.
            //'i < words.Lenght' countinues the loop until it reaches the end of the array.
            // 'i++' increments the loop counter by 1 after each iteration.
            {
                words[i] = words[i].ToUpper();
                //For the current array element, calls the 'ToUpper()' metrhod to convert the string to uppercase.
                //Assigns the uppercase version back to the sameple array index.
            }
                       
        }

        public char FindMissingLetter(char[] array)
        //public allows the method to be access from ouside of the class
        //'char' indicates that the method returns a single charactger.
        {
            char[] letters = "abcdefghijklmnopqrxtuvwxyz".ToCharArray();
            //'char' is used to declare a character array variable name 'letters'.
            //The string "abcdefghijklmnopqrxtuvwxyz" is converted into an array of individials charactger using ToCharArrary().
            //Note: Verify that the string is correct it may have a typo if a full alphabetical sequence was intended.
            

            if (char.IsUpper(array[0]))
                //if the first characeter is uppercase, coverts the hard coded letter sequence to uppercase.
            //The string is first converted to uppercase using ToUpper(), the turned into char array with ToCharArray().
            {
                letters = "abcdefghijklmnopqrxtuvwxyz".ToUpper().ToCharArray();
                //if the first charrater is uppercase, converst the hard coded letter sequence to uppercase.
                //'place' will store the starting index in the 'letter' array that correspond to the first character of the input 'array'.
                
            }
            
            var place = 0;
            //Declare a variable 'place' (the compiler infers its type as int).
            //'place' will store the starting index in the 'letters' array that corresponds to the first character of the input 'array'
            


            for (int j = 0; j < letters.Length; j++)
                //Being a for loop with index 'j' that iterates over every element in the 'letters' array.
            //'int j = 0' : Initializes 'j' to 0
            //'j < letters.Lenght' : The loop cotinues until j reaches the lenght of the 'letters' array.
            //'j++': Increment 'j' by 1 each iteration.
            {
                if (array[0] == letters[j])
                    //Check if the first character of the input 'array' matches the current character in 'letter'
                {
                    place = j;
                    //If a match is found, set 'place' to the current index 'j'
                    break;
                    //Exist the loop immediacy once the staring position is found 
                }
            }

            char missing = ' ';
            //Declare a char variable named 'missing' and initializes it with a blank space.

            for (int i = 0; i < array.Length; i++)
                //Begings another for loop with index 'i' to iterate over the input 'array'.
            //'int i = 0; starts from the first element of the input array.
            //'i < array.Lenght' : Continues intil every elemtn in the 'array' is processed.
            //'i++': Icrements 'i' by 1 in each interatiojn
            {
                if (array[i] != letters[place])
                    //Checks if the current character in the input 'array' dose not match expectged character in 'letters' at the position 'place'.
                {
                    missing = letters[place];
                    //If a mismatch is detected, it means the expected letter is missing 
                    //'missing' is then set to the letter at the current 'place' in 'letters'
                    break;
                    //Exits the loop as soon as the missing letter is found.
                }
                place++;
                //Moves to the nex index in the 'letters' array for comparasion with the next element in the input 'array'.
            }

            return missing;
            //Retruns the 'missing' character found in the sequence.
        }
    }
}