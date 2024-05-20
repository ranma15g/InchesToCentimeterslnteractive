using System;

/*

2-1.1.  Convert the InchesToCentimeters program to an interactive application named InchesToCentimeterslnteractive.

 Instead of assigning a value to the inches variable, accept the value from the user as input.

*/

class Program
{

      static void Main(string[] args)
      {

        /* Here is the interactive portion of the assignment where we are
           checking to see if our user enters a whole number for the inches.
           Whole number because of the parameters of the last assignment had
           us call for an int and that has not changed in the instructions.
           We use a Console.WriteLine() to receive data from the user. */
          Console.WriteLine("Please enter a number with no decimals:");
          var inches = Console.ReadLine(); /* Here is where we assign a value
                                              from user input. */

        /* Here is where we declare a named constant 
        that holds the number of centimeters in 
        an inch: 2.54. */
          const double CENTIMETERS_PER_INCH = 2.54;

                
          /* We created the int int_test to be used as a test 
             on the parse to ensure the user entered a whole 
             number */
          int int_test;


          /* Here we are parsing the input to make sure it fits
             the criteria of an int and not a string. if we did 
             follow instruction and use an integer to be the thing
             we test against for our test Units, it will perform 
             this code */
          if (int.TryParse(inches, out int_test))
          {

            /* Here is where we convert inches to centimeters */
            double centimeters = int_test * CENTIMETERS_PER_INCH;
              /* we implicitly type cased number which is an integer and not
                 inches because that was recorded as a string. */

            /* Our reward for entering the correct data is a message calculating
               inches to centimeter */
            Console.WriteLine("{0} inches is centimeters = {1}.", inches, centimeters);           
    
          }
  
        
        
          else // We did not enter a whole number        
          {
            // We tell the user to go pound sand
            Console.WriteLine("I said a number with no decimals, Good Day Sir.");
          }

      }    
      
}
