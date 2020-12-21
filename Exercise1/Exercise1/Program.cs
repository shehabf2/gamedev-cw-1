using System;

namespace Exercise1
{
    class Program
    {
        static double playerSpeed; // exercise 3

        static void Main(string[] args)
        {
            string characterName = "Ahmed";
            string superPower1 = "steel armor";
            string superPower2 = "night vision";
            int age = 15;
            double speed = 1.65;

            Console.WriteLine("Player 1 is {0} and his age is {1}. His superpowers are {2} and {3}. his speed is {4}", characterName, age, superPower1, superPower2, speed);

            //exercise 2
            string heroName = "Wilson";
            string heroSuperPower1 = "programming";
            string heroSuperpower2 = "engineering";
            double heroHeight = 1.65;
            int heroAge = 23;
            int ageDifference;

            Console.WriteLine("Player 2 is {0} and her age is {1}. Her superpowers are {2} and {3}.", heroName, heroAge, heroSuperPower1, heroSuperpower2);

            ageDifference = Math.Abs(heroAge - age);
            Console.WriteLine("The age Difference between {0} and {1} is {2}", heroName, characterName, ageDifference);

            bool older = heroAge > age;
            Console.WriteLine("Is {0} older than {1}? {2}", heroName, characterName, older);

            bool samePowers = superPower1 == heroSuperPower1;
            Console.WriteLine("Do the players have the same superpowers? {0}", samePowers);

            //exercise 3
            SetSpeed(2.5);

            Console.WriteLine("the current player speed is " + GetSpeed());

        }

        static void SetSpeed(double pspeed) {
            playerSpeed = pspeed;
        }

        static double GetSpeed() {
            return playerSpeed;
        }

    }
}
