using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoFish.Models;

namespace GoFish.Controllers
{
  public class GameController : Controller
  {
    [HttpGet("/game")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
