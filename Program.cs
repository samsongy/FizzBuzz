using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop that goes through every number 1 - 100
            for(int i = 1; i <= 100; i++){

                //if number is a multiple of 5 and 3 then print FizzBuzz
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                } 
                
                //else if number is a multiple of only 3 print Fizz
                else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                } 
                
                //else if number is a multiple of only 5 print Buzz
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                } 
                
                //else print number  
                else{
                    Console.WriteLine(i);
                }

            }
        }
    }
}
