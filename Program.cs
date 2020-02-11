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
      var playAgain = true;
      while (playAgain == true)
      { //request player name
        Console.WriteLine("Please enter your name.");
        var playerName = Console.ReadLine();
        //display a welcome to the game
        Console.WriteLine("Welcome, " + playerName + "! Let's play Rock, Paper, Scissors!");
        //ask player to type in difficulty selection - easy, normal, or impossible
        Console.WriteLine("Please type your difficulty selection. Valid entries are easy, normal, or impossible.");
        //take input and turn into var, then run error checking
        var diffLev = Console.ReadLine().ToLower();
        if (diffLev != "easy" && diffLev != "normal" && diffLev != "impossible")
        {
          Console.WriteLine("That is not a valid entry. Please try again.");
          diffLev = Console.ReadLine().ToLower();
        }
        else
        {
          Console.WriteLine("Thank you. On to the game.");
        }
        //ask user to type in rock, paper, or scissors
        Console.WriteLine("Please type your selection. Valid entries are rock, paper, or scissors.");
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
        var computerInput = "RPS";
        if (diffLev == "normal")
        {
          //create a random number and use result to determine computer decision for playing RPS
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
        }
        else if (diffLev == "easy")
        {
          if (userInput == "rock")
          {
            computerInput = "scissors";
          }
          else if (userInput == "paper")
          {
            computerInput = "rock";
          }
          else if (userInput == "scissors")
          {
            computerInput = "paper";
          }
        }
        else if (diffLev == "impossible")
        {
          if (userInput == "rock")
          {
            computerInput = "paper";
          }
          else if (userInput == "paper")
          {
            computerInput = "scissors";
          }
          else if (userInput == "scissors")
          {
            computerInput = "rock";
          }
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
        Console.WriteLine("Would you like to play again? Valid entries are yes or no.");
        var continuePlaying = Console.ReadLine();
        if (continuePlaying == "no")
        {
          playAgain = false;
        }
        else
        {
          playAgain = true;
        }
      }

    }
  }
}