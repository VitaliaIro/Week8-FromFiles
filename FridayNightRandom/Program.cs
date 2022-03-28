using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string [] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "pasta", "salad", "candies" };
            
            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite", "tea", "water" };
            
            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Interstellar", "Titanic", "Pearl Harbour", "Great Gatsby", "The Hateful Eight", "Kill Bill" };
            
            Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
        }
    }
}
