using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {           
            string randomJoke;
            randomJoke = DisplayJoke("chuck.txt");

            Console.Write($"{randomJoke}");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string DisplayJoke(string fileName)
        {
            string filePath = $@"C:\Users\opilane53\samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }

    }
}
