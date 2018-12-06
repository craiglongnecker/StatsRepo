using System.Web.Mvc;

namespace RealTimeSportsStatistics.Web.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        [HandleError]
        public ActionResult Game()
        {
            return View();
        }
    }
}