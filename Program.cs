﻿using System;

namespace unit02_hilo
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the main chunk of the program where everything comes together. The while loop runs the game as long as the playing 
            //status is true and the starting score is more than 0. The program grabs a number from the getNumber method, and then asks
            //the user if they would like to go higher or lower. The program then takes their answer and determines if the next randomly 
            //generated number was actually as they predicted. In the case of it being correct, the program adds 100 points to the total
            // score, and then asks again. In the case of it being wrong, the program deducts 75 points from the score instead. The user
            //may reroll as many times as they would like, until they press "n" at the prompt, or until their point total goes to 0.
            GameInfo gaming = new GameInfo();

            while (GameInfo.playing == true && GameInfo.startingScore > 0)
            {
                NumberMagic magicNumber = new NumberMagic();
                int firstNumber = NumberMagic.getNumber();
                Console.WriteLine("");
                Console.WriteLine($"The card is: {firstNumber}");
                Console.Write("Higher or Lower? [h/l] ");
                string firstAnswer = Console.ReadLine();
                if (firstAnswer == "h")
                {
                    int secondNumber = NumberMagic.getNumber();
                    Console.WriteLine($"Next card was: {secondNumber}");
                    if (firstNumber < secondNumber)
                    {
                        GameInfo.startingScore += 100;
                        Console.WriteLine($"Your score is: {GameInfo.startingScore}");
                        Console.Write("Play again? [y/n] ");
                        string secondAnswer = Console.ReadLine();
                        if (secondAnswer == "y")
                        {
                            
                        }
                        else if (secondAnswer == "n")
                        {
                            GameInfo.playing = false;
                        }
                    }
                    else if (firstNumber > secondNumber)
                    {
                        GameInfo.startingScore -= 75;
                        Console.WriteLine($"Your score is: {GameInfo.startingScore}");
                        Console.Write("Play again? [y/n] ");
                        string secondAnswer = Console.ReadLine();
                        if (secondAnswer == "y")
                        {

                        }
                        else if (secondAnswer == "n")
                        {
                            GameInfo.playing = false;
                        }
                    }
                }
                else if (firstAnswer == "l")
                {
                    int secondNumber = NumberMagic.getNumber();
                    Console.WriteLine($"Next card was: {secondNumber}");
                    if (firstNumber > secondNumber)
                    {
                        GameInfo.startingScore += 100;
                        Console.WriteLine($"Your score is: {GameInfo.startingScore}");
                        Console.Write("Play again? [y/n] ");
                        string secondAnswer = Console.ReadLine();
                        if (secondAnswer == "y")
                        {
                            
                        }
                        else if (secondAnswer == "n")
                        {
                            GameInfo.playing = false;
                        }
                    }
                    else if (firstNumber < secondNumber)
                    {
                        GameInfo.startingScore -= 75;
                        Console.WriteLine($"Your score is: {GameInfo.startingScore}");
                        Console.Write("Play again? [y/n] ");
                        string secondAnswer = Console.ReadLine();
                        if (secondAnswer == "y")
                        {

                        }
                        else if (secondAnswer == "n")
                        {
                            GameInfo.playing = false;
                        }
                    }
                }
            }
        }

            public class GameInfo
            {
                //This is the class that holds the deciding variables to determine if the game is able to be played or not.
                //Here we have the boolean playing, and the score, that if it drops to 0, will also inhibit the game from 
                //continuing.
                public static bool playing = true;
                public static int startingScore = 300;
            }
            public class NumberMagic
            {
                //This class holds all the necessary parts to get a random number between 1 and 13. It uses an array, as well
                //as the random modifier to select one of the options out of that array. It is reused multiple times in the 
                //program to generate a random number.
            public static int[] cardNumbers = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13};
            public static int getNumber()
            {
                //Here is the actual random choice generator, which pulls from the cardNumbers field to select a card.
                Random rnd = new Random();
                int newNumber = rnd.Next(cardNumbers.Length);
                return newNumber;
            }
            }
    }
}
