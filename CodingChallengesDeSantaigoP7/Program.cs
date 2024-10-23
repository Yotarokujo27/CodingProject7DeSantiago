using System;
using System.ComponentModel.Design;

class Challenges
{
    public static void Main(string[] args)
    {
        //Welcome the user to my program
        Console.WriteLine("Welcome to my coding challenger program. I will be making a variety of functions for you to use. \n Please pick one");

        var Choice = Console.ReadLine()
            bool work = true;
        while (work)
        {
            if (ChoiceInt == 0)
            {
                work = false;
            }
            int ChoiceInt = Int.parse Choice;
            if (ChoiceInt == 1)
            {
                //SumCode
            }
            else if (ChoiceInt == 2)
            {
                function 2 code
            }
            else
            {
            false 
            }
        }
     

        Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers");
        var number1 = Console.ReadLine();
        int numberToUse1 = int.Parse(number1);
        Console.WriteLine("Got it, give me your 2nd number. \n");
        var number2 = Console.ReadLine();
        int numberToUse2 = int.Parse(number2);
        Console.WriteLine(" The sum of the number: " + number1 + " and the number: " + number2 +" is equal to: " + Sum(numberToUse1, numberToUse2));
         Sum(numberToUse1, numberToUse2);


        Console.WriteLine("I am going to convert minutes to seconds.\nPlease input a number to convert.");
        var number3 = Console.ReadLine();
        int numberToUse3 = int.Parse(number3);
        Console.WriteLine("\n" + number3 + " minutes has " + int.Parse(number3) * 60 + " Seconds ");


        Console.WriteLine("We are going to add +1 to a number. Please give me one number");
        var number4 = Console.ReadLine();
        int numberToUse4 = int.Parse(number4);
        Console.WriteLine(" The number: " + number4 + " and " + 1 + " is equal to: " + Sum(numberToUse4, 1));
        Sum(numberToUse4, 1);


        Console.WriteLine("I will take a voltage and current to get the power \n give me a voltage. ");
        var number5 = Console.ReadLine();
        int numberToUse5 = int.Parse(number5);
        Console.WriteLine("Got it, give me your current. \n");
        var number6 = Console.ReadLine();
        int numberToUse6 = int.Parse(number6);
        Console.WriteLine(" The voltage " + number5 + " and current of " + number6 + " is equal to: " + (numberToUse5 * numberToUse6));
        Sum(numberToUse5, numberToUse6);


        Console.WriteLine("\n I am going to convert years to days.\nPlease input a year to convert.");
        var number7 = Console.ReadLine();
        int numberToUse7 = int.Parse(number7);
        Console.WriteLine("\n" + number7 + " years has " + int.Parse(number7) * 365 + " days ");


        Console.WriteLine("\n I will take the base of triangle and the height of it and will return it's area. \n Please give the base.");
        var number8 = Console.ReadLine();
        int numberToUse8 = int.Parse(number8);
        Console.WriteLine("\n Now give the height. \n");
        var number9 = Console.ReadLine();
        int numberToUse9 = int.Parse(number9);
        Console.WriteLine(" The base of " + number8 + " multiplied by the height of " + number9 + " then divided by 2 is " + (numberToUse8 * numberToUse9/2));
       Sum(numberToUse8, numberToUse9/2);


        Console.WriteLine("Today you will give me a number and I will tell you if it is greater or equal to 0. \n Insert a number.");
    }

   


    // See https://aka.ms/new-console-template for more information




}