using Nancy;
using System.Collections.Generic;
using System;
using GameSpace.Objects;

namespace GameSpace
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {

        return View["index.cshtml"];
      };
      Post["/new-game"] =_=> {
        string playerOne = Request.Form["playerOne"];
        string playerTwo = Request.Form["playerTwo"];
        Game newGame = new Game(playerOne, playerTwo);

        Console.WriteLine(playerOne);
        Console.WriteLine(playerTwo);
        return View["results.cshtml", newGame];
      };


    }
  }
}
