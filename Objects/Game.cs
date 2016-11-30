using System;
using System.Collections.Generic;

namespace GameSpace.Objects
{
  public class Game
  {
    public string PlayerOne {get; set;}
    public string PlayerTwo {get; set;}


    public Game(string playerOne, string playerTwo)
    {
      this.PlayerOne = playerOne;
      this.PlayerTwo = playerTwo;
    }
    public string WhoWins()
    {
      if (this.PlayerOne == "rock" && this.PlayerTwo == "paper")
      {
        return "Player Two Wins!";
        }
        else if (this.PlayerOne == "rock" && this.PlayerTwo == "scissors")
        {
          return "Player Two Wins!";
        }
        return "Its a tie!";
      }
  }
}
