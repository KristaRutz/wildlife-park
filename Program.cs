using System;
using System.Collections.Generic;
using WildlifePark.Wildlife;

namespace WildlifePark
{
  public class Program
  {
    
    public static List<Animal> Animals = new List<Animal>();

    public static void Main()
    {
      Console.WriteLine("Welcome to Seattle Wildlife Park.");
      MainMenu();
    }

    public static void PrintList()
    {
      if (Animals.Count > 0)
      {
        Console.WriteLine("See the current list of animals!");
        for (int i = 0; i < Animals.Count; i++)
        {
          Console.WriteLine($"{Animals[i].GetID()}. {Animals[i].GetName()}, {Animals[i].GetAge()} years old");
        }
      } else {
        Console.WriteLine("There are no recorded animals in the Seattle Wildlife Park.");
      }
      MainMenu();
    }

    public static void AddAnimal()
    {
      Console.WriteLine("Add a new Animal!");
      Console.WriteLine("Please enter the name of this animal.");
      string name = Console.ReadLine();
      Console.WriteLine("Please enter the age of this animal.");
      int age = int.Parse(Console.ReadLine());
      Animal animal = new Animal(name, age);
      Animals.Add(animal);
      Console.WriteLine("Your animal has been added!");
      MainMenu();      
    }

    public static void MainMenu()
    {
      Console.WriteLine("MAIN MENU: ['1' to view the animals in the park, '2' to add a new animal, '3' to exit]");

      string menuChoice = Console.ReadLine();

      if (menuChoice == "1")
      {
        PrintList();
      } 
      else if (menuChoice == "2") 
      {
        AddAnimal();
      } 
      else if (menuChoice == "3") 
      {

      } 
      else 
      {
        Main();
      }
    }
  }
}