using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /Employee/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Employee/Welcome
        public string Welcome()
        {
            return "Chào các bạn tớ tên là Cường kòi , đây là Employee Controller  ";
        }
       
    }
}