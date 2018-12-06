using System.Web.Mvc;
namespace Error.Controllers
{
    public class ErrorController : Controller
    {
        //  
        // GET: /Error/  
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NotFound()
        {
            return View();
        }
    }
}