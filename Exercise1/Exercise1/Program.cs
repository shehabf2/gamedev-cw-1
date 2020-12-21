using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Ahmed";
            string superPower1 = "steel armor";
            string superPower2 = "night vision";
            int age = 15;
            double speed = 1.65;

            Console.WriteLine("I am {0} and my age is {1}. My superpowers are {2} and {3}. My speed is {4}", characterName, age, superPower1, superPower2, speed);

            string heroName = "Wilson";
            string heroSuperPower1 = "programming";
            string heroSuperpower2 = "Lighting";
            double heroHeight = 1.65;
            int heroAge = 23;
            int ageDifference;

            ageDifference = heroAge - age;
            Console.WriteLine("The age Difference between {0} and {1} is {2}", heroName, characterName, ageDifference);

            bool older = heroAge > age;
            Console.WriteLine("Is {0} older than {1}? {2}", heroName, characterName, older);
        }
    }
}
