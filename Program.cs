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
        Console.WriteLine("Welcome, " + playerName + "! Let's play Rock, Paper, Scissors, Lizard, Spock!");
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
        //ask user to type in rock, paper, scissors, lizard, spock
        Console.WriteLine("Please type your selection. Valid entries are rock, paper, scissors, lizard, or spock.");
        //create variable from player input
        var userInput = Console.ReadLine().ToLower();
        //error correction on RPS input
        if (userInput != "rock" && userInput != "paper" && userInput != "scissors" && userInput != "lizard" && userInput != "spock")
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
          int randOutput = rand1.Next(1, 5);
          if (randOutput == 1)
          {
            computerInput = "rock";
          }
          else if (randOutput == 2)
          {
            computerInput = "paper";
          }
          else if (randOutput == 3)
          {
            computerInput = "scissors";
          }
          else if (randOutput == 4)
          {
            computerInput = "lizard";
          }
          else if (randOutput == 5)
          {
            computerInput = "spock";
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
          else if (userInput == "lizard")
          {
            computerInput = "spock";
          }
          else if (userInput == "spock")
          {
            computerInput = "rock";
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
          else if (userInput == "lizard")
          {
            computerInput = "rock";
          }
          else if (userInput == "spock")
          {
            computerInput = "lizard";
          }
        }
        //Display the computer's selection
        Console.WriteLine("The computer selected " + computerInput + ".");
        //compare the inputs of user and computer and determine winner
        if (computerInput == "rock" || computerInput == "spock" && userInput == "scissors")
        {
          Console.WriteLine(playerName + ", sorry. You lost.");
        }
        else if (computerInput == "paper" || computerInput == "spock" && userInput == "rock")
        {
          Console.WriteLine(playerName + ", sorry. You lost.");
        }
        else if (computerInput == "scissors" || userInput == "lizard" && userInput == "paper")
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