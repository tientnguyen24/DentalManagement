using Microsoft.AspNetCore.Mvc;

namespace DentalManagement.Admin.Controllers
{
    public class MedicalBillController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
