using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(4, 6) + 1;
        }

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