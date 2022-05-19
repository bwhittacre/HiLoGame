using System;
namespace unit02_hilo.GameCalculations;

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