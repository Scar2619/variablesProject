using System;

namespace variablesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Katelind";
            int myAge = 28;
            char nickName = 'K';
            bool lovesHiking = true;
            double visitCountry = 9;
            decimal newPlaces = 700.5m;

            Console.WriteLine($"My name is {myName} and I am {myAge} years old, My nickname is {nickName} and it is {lovesHiking} that I love to hike");
            Console.WriteLine($" ");
            Console.WriteLine($"I have visited {visitCountry} different countries, but want to see the other {newPlaces} too");
        }
    }
}

