using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using GoFish.Models;

namespace GoFish.Controllers
{
  public class playersController : Controller
  {
    [HttpGet("/players")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
