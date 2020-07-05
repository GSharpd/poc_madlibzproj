using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program MadLibz
      Author: Mad (lmao)
      */


      // Let the user know that the program is starting:

      Console.WriteLine("The story is about to begin!");


      // Give the Mad Lib a title:
      string title = "Limp Dick Assassins";

      Console.WriteLine(title);
      // Define user input and variables:

      Console.Write("Whos is the main character of our story? ");
      string name = Console.ReadLine();

      Console.Write("Enter a first adjective: ");
      string adj1 = Console.ReadLine();

      Console.Write("Enter another adjective: ");
      string adj2 = Console.ReadLine();

      Console.Write("Enter a final adjective: ");
      string adj3 = Console.ReadLine();

      Console.Write("Enter something that our main character is doing: ");
      string verb = Console.ReadLine();

      Console.Write("Now tell me 2 nouns: ");
      string noun1 =  Console.ReadLine();
      string noun2 =  Console.ReadLine();

      Console.WriteLine("Pick one of each of these itens and tell me what you chose in this order: an animal, a food, a fruit, a superhero, a country, a dessert, a year: ");

      string animal = Console.ReadLine();
      string food =  Console.ReadLine();
      string fruit = Console.ReadLine();
      string super = Console.ReadLine();
      string country = Console.ReadLine();
      string dessert = Console.ReadLine();
      string year = Console.ReadLine();




      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {super}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:

      Console.WriteLine(story);

    }
  }
}
