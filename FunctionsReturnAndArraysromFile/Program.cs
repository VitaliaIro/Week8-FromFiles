using System;

namespace FunctionsReturnAndArraysromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "pasta", "salad", "candies" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite", "tea", "water"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Interstellar", "Titanic", "Pearl Harbour", "Great Gatsby", "The Hateful Eight", "Kill Bill" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}");
        }

    }
}
