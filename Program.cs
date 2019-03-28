using System;

namespace RPSharper
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine(@"

______               _        ______                                _____        _                              _ 
| ___ \             | |       | ___ \                              /  ___|      (_)                            | |
| |_/ /  ___    ___ | | __    | |_/ /  __ _  _ __    ___  _ __     \ `--.   ___  _  ___  ___   ___   _ __  ___ | |
|    /  / _ \  / __|| |/ /    |  __/  / _` || '_ \  / _ \| '__|     `--. \ / __|| |/ __|/ __| / _ \ | '__|/ __|| |
| |\ \ | (_) || (__ |   <  _  | |    | (_| || |_) ||  __/| |    _  /\__/ /| (__ | |\__ \\__ \| (_) || |   \__ \|_|
\_| \_| \___/  \___||_|\_\( ) \_|     \__,_|| .__/  \___||_|   ( ) \____/  \___||_||___/|___/ \___/ |_|   |___/(_)
                          |/                | |                |/                                                 
                                            |_|                                                                   

");
      Random rnd = new Random();
      bool play = true;


      while (play)
      {
        Console.WriteLine("Please choose Rock, Paper, or Scissors");
        string input = Console.ReadLine().ToLower();

        string[] choice = new string[3];
        choice[0] = "rock";
        choice[1] = "scissors";
        choice[2] = "paper";
        int number = rnd.Next(0, choice.Length);
        string compChoice = choice[number];

        if (input == "paper")
        {
          if (compChoice == "paper")
          {
            Console.WriteLine("Draw.. Give it another try");
          }
          else if (compChoice == "rock")
          {
            Console.WriteLine("Hey this computer chose rock so guess what! YOU WIN!");
          }
          else if (compChoice == "scissors")
          {
            Console.WriteLine("You've been cut in half! You Lose. Give it another try");
          }
          else
          {
            Console.WriteLine("How bout you learn to spell or write your correct choice please!");
            continue;
          }
        }

        if (input == "rock")
        {
          if (compChoice == "rock")
          {
            Console.WriteLine("Do you like hitting rocks together? Draw! Give it another try");
          }
          else if (compChoice == "paper")
          {
            Console.WriteLine("You would think rocks would beat paper, but it doesn't You Lose! Give it another try");
          }
          else if (compChoice == "scissors")
          {
            Console.WriteLine(
                "Well scissors tends to get crushed by rocks... You WIN!!");
          }
          else
          {
            Console.WriteLine("How bout you learn to spell or write your correct choice please!");
            continue;
          }
        }

        if (input == "scissors")
        {
          if (compChoice == "scissors")
          {
            Console.WriteLine(
                "Be careful you don't want to get into a scissor fight! Draw.. Give it another try");
          }
          else if (compChoice == "rock")
          {
            Console.WriteLine(
                "Rocks destroy scissors like they are scissors being hit with a rock! You lose.. Give it another try");
          }
          else if (input == "paper")
          {
            Console.WriteLine("Scissors are very good and cutting paper! You win!");
          }
          else
          {
            Console.WriteLine("How bout you learn to spell or write your correct choice please!");
          }
        }
      }
    }
  }
}