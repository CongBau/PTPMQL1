using Microsoft.AspNetCore.Mvc;
using First_web_Mvc.Models;

namespace First_web_Mvc.Controllers
{
    public class CongcutinhtoanController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TinhToan());
        }

        [HttpPost]
        public IActionResult Index(TinhToan model)
        {
            switch (model.PhepTinh)
            {
                case "cong":
                    model.KetQua = model.So1 + model.So2;
                    break;
                case "tru":
                    model.KetQua = model.So1 - model.So2;
                    break;
                case "nhan":
                    model.KetQua = model.So1 * model.So2;
                    break;
                case "chia":
                    if (model.So2 != 0)
                        model.KetQua = model.So1 / model.So2;
                    else
                        model.ThongBao = "Không thể chia cho 0";
                    break;
            }

            return View(model);
        }
    }
}
