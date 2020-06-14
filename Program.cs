using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name a Genre and I'll tell you the best movie in it!");
            string userAsk = Console.ReadLine();
            string genre = userAsk.ToLower(); //this was my idea, and not something Codecademy suggested. IT takes whateer the input is and makes it mathch the genre variable


            switch (genre)
            {
                case "drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "comedy":
                    Console.WriteLine("Duck Soup");
                    break;
                case "adventure":
                    Console.WriteLine("King Kong");
                    break;
                case "horror":
                    Console.WriteLine("Psycho");
                    break;
                case "science fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;
                default:
                    Console.WriteLine("Please pick: Comedy, Adventure, Drama, Horror, or Science Fiction");
                    break;
            }

        }
    }
}
