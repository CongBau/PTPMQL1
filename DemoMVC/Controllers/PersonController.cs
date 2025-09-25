using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        // GET: /Person/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Person/Welcome
        public string Welcome()
        {
            return "Chào các bạn tớ tên là Bau ";
        }
    }
}