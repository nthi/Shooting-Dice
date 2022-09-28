using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    //is this a custom exception? -- it can be any exception i want to break the code
    //"Try" is the roll up to the winning message
    //"Catch" is ... custom or other exception? ... then maybe a "Flips the table" or "I can't lose" or something message?
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {


            try
            {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            if (myRoll < otherRoll)
            {
                throw new InvalidOperationException();
            }
            // //if (roll means player loses)
            // //throw new InvalidOperationException();
            // //then do a try/catch

                Console.WriteLine($"{Name} rolls a {myRoll}");
                Console.WriteLine($"{other.Name} rolls a {otherRoll}");
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Everything went disastrously wrong!");
            }
        }
    }
}