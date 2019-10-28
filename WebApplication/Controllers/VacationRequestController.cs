using Microsoft.AspNetCore.Mvc;
using WebApplication.LKB;

namespace WebApplication.Controllers
{
    public class VacationRequestController : Controller
    {
        // GET
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Morakhasi model)
        {
            return View();
        }
        
        public IActionResult Edit(int id)
        {
            return View();
        }
        
        public IActionResult EditConfirmed(Morakhasi model)
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Delete(int id)
        {
            return View();
        }
        
        
    }
}