using Microsoft.AspNetCore.Mvc;
using Mad.Models;
namespace Mad.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult HomePage() {return View(); }
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/mad-lib")]
    public ActionResult Mad(string name, string adjective, string propernoun, string adjective2, string verb, string verb2, string noun2, string yourname, string verb3)
    {
    MadVariable myMadVariable = new MadVariable();
    myMadVariable.Name = name;
    myMadVariable.Adjective = adjective;
    myMadVariable.ProperNoun = propernoun;
    myMadVariable.Adjective2 = adjective2;
    myMadVariable.Verb = verb;
    myMadVariable.Verb2 = verb2;
    myMadVariable.Noun2 = noun2;
    myMadVariable.YourName = yourname;
    myMadVariable.Verb3 = verb3;
    return View(myMadVariable);
    }
  }
}