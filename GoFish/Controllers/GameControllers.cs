using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoFish.Models;

namespace GoFish.Controllers
{
  public class GameController : Controller
  {
    public static Game Game;
    public static Player Winner;

    [HttpGet("/game")]
    public ActionResult Index()
    {
      if (Game.End())
      {
        Winner = Game.GetWinner();
      }
      (Game, Player) model = (Game, Winner);
      return View(model);
    }

    [HttpPost("/game")]
    public ActionResult Create(int numOfPlayers)
    {
      Game = new Game(numOfPlayers);
      Winner = null;
      return RedirectToAction("Index");
    }

    [HttpGet("/game/{id}")]
    public ActionResult SelectPlayer(int id)
    {
      (Game, int) model = (Game, id);
      return View("SelectPlayer", model);
    }

    [HttpGet("/game/{name}/{id}")]
    public ActionResult Show(string name, int id)
    {
      (Game, int, string) model = (Game, id, name);
      return View("Show", model);
    }

    [HttpGet("/game/{name}/{id}/{success}")]
    public ActionResult BackToIndex(string name, int id, bool success)
    {
      return RedirectToAction("Index");
    }
  }
}
