using Xunit;
using System;
using System.Collections.Generic;
using GameSpace.Objects;

namespace  GameSpace
{
  public class GameTest
  {
    [Fact]
    public void WhoWins_PaperBeatsRock_true()
    {
      //Arrange
      string PlayerOne = "rock";
      string PlayerTwo = "paper";
      Game newGame = new Game(PlayerOne, PlayerTwo);
      //Act
      //Assert
      string winner = "Player Two Wins!";
      Assert.Equal(true, newGame.WhoWins() == winner);
    }
    [Fact]
    public void WhoWins_RockBeatsScissors_true()
    {
      //Arrange
      string PlayerOne = "rock";
      string PlayerTwo = "scissors";
      Game newGame = new Game(PlayerOne, PlayerTwo);
      //Act
      //Assert
      string winner = "Player One Wins!";
      Assert.Equal(true, newGame.WhoWins() == winner);
    }
    [Fact]
    public void WhoWins_ScissorsBeatsPaper_true()
    {
      //Arrange
      string PlayerOne = "paper";
      string PlayerTwo = "scissors";
      Game newGame = new Game(PlayerOne, PlayerTwo);
      //Act
      //Assert
      string winner = "Player Two Wins!";
      Assert.Equal(true, newGame.WhoWins() == winner);
    }
    [Fact]
    public void WhoWins_Tie_true()
    {
      //Arrange
      string PlayerOne = "paper";
      string PlayerTwo = "paper";
      Game newGame = new Game(PlayerOne, PlayerTwo);
      //Act
      //Assert
      string winner = "It's a Tie!";
      Assert.Equal(true, newGame.WhoWins() == winner);
    }
  }
}
