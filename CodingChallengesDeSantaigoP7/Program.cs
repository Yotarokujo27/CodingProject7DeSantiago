using System;
using System.ComponentModel.Design;

class Challenges
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Welcome the user to my program
            Console.WriteLine("Welcome to my coding challenger program. I will be making a variety of functions for you to use. \n Please pick one");

            Console.WriteLine("\n Please pick one from the  list. \n0 Exit\n1: Sum\n2: Min to Sec\n3: Plus one\n4: Voltage times Current\n5: Age in days\n6: Area of Triangle\n7: Less Than Or Equal");

            string Num = Console.ReadLine();
            int parsed;
            if (int.TryParse(Num, out parsed))
            {
                if (parsed <= 10 && parsed >= 0);
            }
            else
            {
                Console.WriteLine("Please give a valid function.");
            }
        }

        static void Exit()
        {
            Environment.Exit(0);
        }

        static void Adder()
        {
            Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine("Got it, give me your 2nd number. \n");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse(number2);
            Console.WriteLine(" The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));
            Sum(numberToUse1, numberToUse2);
        }

        static void Min()
        {
            Console.WriteLine("I am going to convert minutes to seconds.\nPlease input a number to convert.");
            var number3 = Console.ReadLine();
            int numberToUse3 = int.Parse(number3);
            Console.WriteLine("\n" + number3 + " minutes has " + int.Parse(number3) * 60 + " Seconds ");
        }

        static void Plus()
        {
            Console.WriteLine("We are going to add +1 to a number. Please give me one number");
            var number4 = Console.ReadLine();
            int numberToUse4 = int.Parse(number4);
            Console.WriteLine(" The number: " + number4 + " and " + 1 + " is equal to: " + (numberToUse4, 1));
            Sum(numberToUse4, 1);
        }

        static void Volt()
        {
            Console.WriteLine("I will take a voltage and current to get the power \n give me a voltage. ");
            var number5 = Console.ReadLine();
            int numberToUse5 = int.Parse(number5);
            Console.WriteLine("Got it, give me your current. \n");
            var number6 = Console.ReadLine();
            int numberToUse6 = int.Parse(number6);
            Console.WriteLine(" The voltage " + number5 + " and current of " + number6 + " is equal to: " + (numberToUse5 * numberToUse6));
            Sum(numberToUse5, numberToUse6);
        }

        static void DaytoYears()
        {
            Console.WriteLine("\n I am going to convert years to days.\nPlease input a year to convert.");
            var number7 = Console.ReadLine();
            int numberToUse7 = int.Parse(number7);
            Console.WriteLine("\n" + number7 + " years has " + int.Parse(number7) * 365 + " days ");
        }


        static void Triangle()
        {
            Console.WriteLine("\n I will take the base of triangle and the height of it and will return it's area. \n Please give the base.");
            var number8 = Console.ReadLine();
            int numberToUse8 = int.Parse(number8);
            Console.WriteLine("\n Now give the height. \n");
            var number9 = Console.ReadLine();
            int numberToUse9 = int.Parse(number9);
            Console.WriteLine(" The base of " + number8 + " multiplied by the height of " + number9 + " then divided by 2 is " + (numberToUse8 * numberToUse9 / 2));
            Sum(numberToUse8, numberToUse9 / 2);

        }

        static void LessthanorEqual()
        {

        }
        


        
    }
    
    


    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    //hello


    // See https://aka.ms/new-console-template for more information




}