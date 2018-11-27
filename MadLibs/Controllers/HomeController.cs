using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/story1")]
    public ActionResult MadLibOne(string name, string place, string seoson, string exclamation)
    {
      MadLibModels myStory = new MadLibModels();
      myStory.SetName(name);
      myStory.SetPlace(place);
      myStory.SetSeoson(seoson);
      myStory.SetExclamation(exclamation);
       return View(myStory);
     }

   [Route("/story1")]
   public ActionResult MadLibRwo(string name, string adjective, string exclamation, string seoson)
    {
     MadLibModels secondStory = new MadLibModels();
     secondStory.SetName(name);
     secondStory.SetAdjective(adjective);
     secondStory.SetExclamation(exclamation);
     secondStory.SetSeoson(seoson);
      return View(secondStory);
    }

    [Route("/form1")]
    public ActionResult Form1() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/index")]
    public ActionResult Index() { return View(); }
  }
}
