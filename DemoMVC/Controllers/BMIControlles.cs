using Microsoft.AspNetCore.Mvc;
using First_web_Mvc.Models;

namespace First_web_Mvc.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BMI());
        }

        [HttpPost]
        public IActionResult Index(BMI model)
        {
            if (model.ChieuCao > 0)
            {
                model.GiaTriBMI = model.CanNang / (model.ChieuCao * model.ChieuCao);

                if (model.GiaTriBMI < 18.5)
                    model.DanhGia = "Thiếu cân";
                else if (model.GiaTriBMI < 24.9)
                    model.DanhGia = "Bình thường";
                else if (model.GiaTriBMI < 29.9)
                    model.DanhGia = "Thừa cân";
                else
                    model.DanhGia = "Béo phì";
            }

            return View(model);
        }
    }
}
