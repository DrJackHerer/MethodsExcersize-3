using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {

        //        Write a method that will print to the console all numbers 1000 through -1000
        public static void Print1000s()
        {
            for(var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        
            






        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Show3s()
        {
            for (int i =3; i<= 999; i+=3)
            {
                Console.WriteLine(i);
            }      
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void TwoIntsEqual(int num1, int num2)
        {
            //if(num1 == num2)
            //{
            //    Console.WriteLine("Numbers are Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are not equal");
            //}

            //ternary Meth
            Console.WriteLine((num1 == num2) ? "Numbers are equal." : "Numbers are not equal");
        }


        //Write a method to check whether a given number is even or odd

        public static void OddOrEven(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else 
            {
                Console.WriteLine($"{number} number is odd");
            }
            
        }
        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if(num < 0)
            {
                Console.WriteLine($"{num} is 0");
            }
            else
            {
                Console.WriteLine($"{num}neither pos itive or negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge

        public static void AgeCheck()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine(" Please enter your age: ");

                userAge = int.TryParse(Console.ReadLine(), out result);

            }while(!userAge);

            if(result < 18)
            {
                Console.WriteLine("Very sorry you are not old enough to vote");
            }
            else
            {
                Console.WriteLine("You are elgible to vote");
            }
        }

        public static void inRange()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an Integer.");
                userResponse = int.TryParse(Console.ReadLine(), out result);
            }while(!userResponse);

            if(result >= -10 &&  result <= 10)
            {
                Console.WriteLine($"{result} is between -10 and 10");
            }
            else
            {
                System.Console.WriteLine($"{result} is not between -10 and 10");
            }
        }
        public static void MultTable()
        {
            bool userResponse;
            int result;

            do
            {
                Console.WriteLine("Enter an Integer");

                userResponse = int.TryParse(Console.ReadLine(), out result);

            }while(!userResponse);

            for(var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {result} = {x * result}");
            }
        }



        //Parse()
        //TryParse()
        static void Main(string[] args)
        {
            //Print1000s();

            //PrintThrees();

            //TwoIntsEqual(75,50);

            //MultTable();

            //Show3s();

            OddOrEven(21);

            //ageCheck();
            //inRange();


        }

    }
}
