using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/madlib1")]
    public ActionResult MadLib1(string name, string place, string season, string exclamation)
    {
      MadLibModels myStory = new MadLibModels();
      myStory.SetName(name);
      myStory.SetPlace(place);
      myStory.SetSeason(season);
      myStory.SetExclamation(exclamation);

      return View(myStory);
     }

   [Route("/madlib2")]
   public ActionResult MadLib2(string name, string adjective, string exclamation, string season)
    {
      MadLibModels secondStory = new MadLibModels();
      secondStory.SetName(name);
      secondStory.SetAdjective(adjective);
      secondStory.SetExclamation(exclamation);
      secondStory.SetSeason(season);

      return View(secondStory);
    }

    [Route("/form1")]
    public ActionResult Form1() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/")]
    public ActionResult Index() { return View(); }
  }
}
