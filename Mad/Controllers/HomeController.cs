using Microsoft.AspNetCore.Mvc;
using Mad.Models;
namespace Mad.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult HomePage() { return View(); }
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/form3")]
    public ActionResult Form3() { return View(); }

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

    [Route("/mad-lib-2")]
    public ActionResult Mad2(string adjective1, string adjective2, string adjective3, string adverb, string noun1, string noun2, string noun3, string number, string pluralnoun1, string pluralnoun2, string pluralnoun3)
    {
    MadVariable2 myMadVariable = new MadVariable2();
    myMadVariable.Adjective1 = adjective1;
    myMadVariable.Adjective2 = adjective2;
    myMadVariable.Adjective3 = adjective3;
    myMadVariable.Adverb = adverb;
    myMadVariable.Noun1 = noun1;
    myMadVariable.Noun2 = noun2;
    myMadVariable.Noun3 = noun3;
    myMadVariable.Number = number;
    myMadVariable.PluralNoun1 = pluralnoun1;
    myMadVariable.PluralNoun2 = pluralnoun2;
    myMadVariable.PluralNoun3 = pluralnoun3;
    return View(myMadVariable);
    }    

    [Route("/mad-lib-3")]
    public ActionResult Mad3(string verbing, string adjective1, string pluralnoun1, string bodypart1, string adverb, string bodypart2, string adjective2, string noun1, string pluralnoun2, string verb1, string pluralnoun3, string noun2, string noun3, string bodypart3, string verb2)
    {
    MadVariable3 myMadVariable = new MadVariable3();
    myMadVariable.Verbing = verbing;
    myMadVariable.Adjective1 = adjective1;
    myMadVariable.PluralNoun1 = pluralnoun1;
    myMadVariable.BodyPart1 = bodypart1;
    myMadVariable.Adverb = adverb;
    myMadVariable.BodyPart2 = bodypart2;
    myMadVariable.Adjective2 = adjective2;
    myMadVariable.Noun1 = noun1;
    myMadVariable.PluralNoun2 = pluralnoun2;
    myMadVariable.Verb1 = verb1;
    myMadVariable.PluralNoun3 = pluralnoun3;
    myMadVariable.Noun2 = noun2;
    myMadVariable.Noun3 = noun3;
    myMadVariable.BodyPart3 = bodypart3;
    myMadVariable.Verb2 = verb2;
    return View(myMadVariable);
    }    
  }
}