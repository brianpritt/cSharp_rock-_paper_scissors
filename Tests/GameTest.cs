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
  }
}
