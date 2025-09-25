using Microsoft.AspNetCore.Mvc;
using First_web_Mvc.Models;

namespace First_web_Mvc.Controllers
{
    public class TinhTuoiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Tuoi());
        }

        [HttpPost]
        public IActionResult Index(Tuoi model)
        {
            if (model.NamSinh > 0)
            {
                int namHienTai = DateTime.Now.Year;
                model.TinhTuoi = namHienTai - model.NamSinh;
            }

            return View(model);
        }
    }
}
