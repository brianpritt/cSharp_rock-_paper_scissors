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
      if ((this.PlayerOne == "rock" && this.PlayerTwo == "paper") || (this.PlayerOne == "scissors" && this.PlayerTwo == "rock") || (this.PlayerOne == "paper" && this.PlayerTwo == "scissors"))
      {
        return "Player Two Wins!";
        }
        else if ((this.PlayerOne == "rock" && this.PlayerTwo == "scissors") || (this.PlayerOne == "paper" && this.PlayerTwo == "rock") || (this.PlayerOne == "scissors" && this.PlayerTwo == "paper"))
        {
          return "Player One Wins!";
        }
        return "Its a tie!";
      }
  }
}
