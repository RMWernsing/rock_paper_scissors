internal class Program
{
  static int userScore = 0;
  static int computerScore = 0;
  private static void Main()
  {

    Console.WriteLine($"Your score: {userScore}");
    Console.WriteLine($"Computers score: {computerScore}");
    Console.WriteLine();

    string userHand = ChooseHand();
    string computerHand = GetComputerHand();

    Console.Clear();
    Console.WriteLine($"Your score: {userScore}");
    Console.WriteLine($"Computers score: {computerScore}");
    Console.WriteLine();

    string winStatement = "CONGRATULATIONS YOU WON";
    string loseStatement = "Sorry, you lost";
    string tieStatement = "It's a tie";

    if (userHand == "Rock" && computerHand == "Scissors")
    {
      Console.Clear();
      Console.WriteLine($"You have selected {userHand}");
      Console.WriteLine($"The computer has selected {computerHand}");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(winStatement);
      Console.ResetColor();
      userScore++;
    }
    else if (userHand == "Scissors" && computerHand == "Paper")
    {
      Console.Clear();
      Console.WriteLine($"You have selected {userHand}");
      Console.WriteLine($"The computer has selected {computerHand}");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(winStatement);
      Console.ResetColor();
      userScore++;
    }
    else if (userHand == "Paper" && computerHand == "Rock")
    {
      Console.Clear();
      Console.WriteLine($"You have selected {userHand}");
      Console.WriteLine($"The computer has selected {computerHand}");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(winStatement);
      Console.ResetColor();
      userScore++;
    }
    else if (userHand == computerHand)
    {
      Console.Clear();
      Console.WriteLine($"You have selected {userHand}");
      Console.WriteLine($"The computer has selected {computerHand}");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(tieStatement);
      Console.ResetColor();
    }
    else
    {
      Console.Clear();
      Console.WriteLine($"You have selected {userHand}");
      Console.WriteLine($"The computer has selected {computerHand}");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(loseStatement);
      Console.ResetColor();
      computerScore++;
    }

    bool wantsToPlayAgain = PlayAgain();
    if (wantsToPlayAgain)
    {
      Console.Clear();
      Main();
    }
    else
    {
      if (userScore > computerScore)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("YOU WON THE GAME");
        Console.ResetColor();
      }
      else if (userScore == computerScore)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You Tied");
        Console.ResetColor();
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lost :(");
        Console.ResetColor();
      }
    }
  }

  static string ChooseHand()
  {
    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");

    string? userInput = Console.ReadLine();
    string userSelection = "";
    if (userInput != "1" && userInput != "2" && userInput != "3")
    {
      Console.WriteLine("You did not select one of the options given to you. Please try again");
      return ChooseHand();
    }
    {

    }
    if (userInput == "1")
    {
      userSelection = "Rock";
      return userSelection;
    }
    else if (userInput == "2")
    {
      userSelection = "Paper";
      return userSelection;
    }
    else if (userInput == "3")
    {
      userSelection = "Scissors";
      return userSelection;
    }
    return userSelection;
  }
  static string GetComputerHand()
  {
    int randomNumber = new Random().Next(1, 4);
    string computerSelection = "";
    if (randomNumber == 1)
    {
      computerSelection = "Rock";
      return computerSelection;
    }
    else if (randomNumber == 2)
    {
      computerSelection = "Paper";
      return computerSelection;
    }
    else if (randomNumber == 3)
    {
      computerSelection = "Scissors";
      return computerSelection;
    }
    return computerSelection;

  }

  static bool PlayAgain()
  {
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("y/n");
    char userInput = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (userInput != 'y' && userInput != 'n')
    {
      return PlayAgain();
    }
    return userInput == 'y';
  }

}