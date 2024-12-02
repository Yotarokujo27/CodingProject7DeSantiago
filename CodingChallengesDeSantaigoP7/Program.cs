using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

class Challenges
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

        }
        private static bool MainMenu()
        {

            Console.WriteLine("\n Please pick one from the  list. \n0 Exit\n1: Sum\n2: Min to Sec\n3: Plus one\n4: Voltage times Current\n5: Age in days\n6: Area of Triangle\n7: Less Than Or Equal\n8: Less than 100\n9: Equal to\n10: Something\n11: Reverse\n12: Hours to Seconds\n13: Polygon\n");



            switch (Console.ReadLine())
            {
                case "1":
                    Adder();
                    return true;
                case "2":
                    MintoSec();
                    return true;
                case "3":
                    Plusone();
                    return true;
                case "4":
                    VoltagetimesCurrent();
                    return true;
                case "5":
                    Ageindays();
                    return true;
                case "6":
                    AreaofTriangle();
                    return true;
                case "7":
                    LessThanOrEqual();
                    return true;
                case "8":
                    LessThan100();
                    return true;
                case "9":
                    EqualTo();
                    return true;
                case "10":
                    Something();
                    return true;
                case "11":
                    Reverse ();
                    return true;
                case "12":
                    HoursToSeconds();
                    return true;
                case "13":
                    Polygon();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }


        }

       

        private static void Adder()
        {
            Console.WriteLine("We are going to use the number adder today called sum. \n Please give me two numbers");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine("Got it, give me your 2nd number. \n");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse(number2);
            Console.WriteLine(" The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));
            Sum(numberToUse1, numberToUse2);

        }

        private static void MintoSec()
        {
            Console.WriteLine("I'm going to convert minutes to seconds.\n Please input a miutee to convert.");
            var number3 = Console.ReadLine();
            int numberToUse3 = int.Parse(number3);
            Console.WriteLine("\n" + number3 + " minutes has " + int.Parse(number3) * 60 + " Seconds ");

        }

        private static void Plusone()
        {
            Console.WriteLine("We are going to add +1 to a number. \n Please give a number");
            var number4 = Console.ReadLine();
            int numberToUse4 = int.Parse(number4);
            Console.WriteLine(" The number: " + number4 + " and " + 1 + " is equal to: " + (numberToUse4  + 1));
            Sum(numberToUse4 , 1);
        }

        private static void VoltagetimesCurrent()
        {
            Console.WriteLine("I will take a voltage x current to get the power \n give me a voltage. ");
            var number5 = Console.ReadLine();
            int numberToUse5 = int.Parse(number5);
            Console.WriteLine("Got it, give me your current. \n");
            var number6 = Console.ReadLine();
            int numberToUse6 = int.Parse(number6);
            Console.WriteLine(" The voltage " + number5 + " times the current of " + number6 + " is equal to: " + (numberToUse5 * numberToUse6));
            Sum(numberToUse5, numberToUse6);
        }
        private static void Ageindays()
        {
            Console.WriteLine("\n I am going to convert years to days.\n Please input a year to convert.");
            var number7 = Console.ReadLine();
            int numberToUse7 = int.Parse(number7);
            Console.WriteLine("\n" + number7 + " years has " + int.Parse(number7) * 365 + " days ");
        }
        private static void AreaofTriangle()
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

        static bool LessThanOrEqual(bool value)
        {
            
            Console.WriteLine("I will take a number and return if it's less than or equal to zero. \nInput a number");
            int main()
            {
                
                var number10 = Console.ReadLine();
                int numberToUse10 = int.Parse(number10);
                int a = int.Parse(number10);
                int b = 0;

                // Conditional Statements
                if (a > b)
                {
                    ("a is equal\n");
                }
                else (a > b)
                {
                    ("a is smaller\n");
                }

                return 0;

            }

        }

        private static void LessThan100()
        {

        }
        
     

            private static void EqualTo()
        {
            Console.WriteLine("I will take a number and return if it's less than, above, or equal to zero. \n Input a number");
            {
                {
                   
                }
            }

        }

        private static void Something()
        {
            Console.WriteLine("I will something and add something to it. \n Input something");
            {
                
                
            }

        }

        private bool Reverse(bool value)
        {
            Console.WriteLine("I will take a number and return if it's less than, above, or equal to zero. \n Input a number");
            {
                
                {
                   
                }
            }
        }

        private static void HoursToSeconds()
        {
            Console.WriteLine("\n I am going to convert hours to seconds.\n Please give an hour or hours.");
            var number20 = Console.ReadLine();
            int numberToUse20 = int.Parse(number20);
            Console.WriteLine("\n" + number20 + " hour(s) has " + int.Parse(number20) * 3600 + " seconds ");
        }

        private static void Polygon()
        {
            Console.WriteLine("I will return the sum of internal angles(in degrees) of a polygon \n Input a number");
            {
                 
            }
           
        }

    }
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

}
