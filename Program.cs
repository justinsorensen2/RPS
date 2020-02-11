using System;

namespace RPS
{
  [System.Runtime.InteropServices.ComVisible(true)]
  [System.Serializable]
  public class RandomNumbers { }
  class Program
  {
    static void Main(string[] args)
    {
      //request player name
      Console.WriteLine("Please enter your name.");
      var playerName = Console.ReadLine();
      //display a welcome to the game
      Console.WriteLine("Welcome, " + playerName + "! Let's play Rock, Paper, Scissors!");
      //ask user to type in rock, paper, or scissors
      Console.WriteLine("Please type your selection.");
      Console.WriteLine("Valid entries are rock, paper, or scissors.");
      //create variable from player input
      var userInput = Console.ReadLine().ToLower();
      //error correction on RPS input;
      if (userInput != "rock" && userInput != "paper" && userInput != "scissors")
      {
        Console.WriteLine("That is not a valid entry. Please try again.");
        userInput = Console.ReadLine().ToLower();
      }
      else
      {
        Console.WriteLine("Thank you.");
      }
      //create a random number and use result to determine computer decision for playing RPS
      var computerInput = "RPS";
      Random rand1 = new Random();
      int randOutput = rand1.Next(1, 100);
      if (randOutput >= 1 && randOutput < 33)
      {
        computerInput = "rock";
      }
      else if (randOutput > 33 && randOutput < 66)
      {
        computerInput = "paper";
      }
      else if (randOutput > 66 && randOutput <= 100)
      {
        computerInput = "scissors";
      }
      //Display the computer's selection
      Console.WriteLine("The computer selected " + computerInput + ".");
      //compare the inputs of user and computer and determine winner
      if (computerInput == "rock" && userInput == "scissors")
      {
        Console.WriteLine(playerName + ", sorry. You lost.");
      }
      else if (computerInput == "paper" && userInput == "rock")
      {
        Console.WriteLine(playerName + ", sorry. You lost.");
      }
      else if (computerInput == "scissors" && userInput == "paper")
      {
        Console.WriteLine(playerName + ", sorry. You lost.");
      }
      else if (computerInput == userInput)
      {
        Console.WriteLine("The game was tied.");
      }
      else
      {
        Console.WriteLine(playerName + ", you win!!!! Congrats!!");
      }

    }
  }
}
