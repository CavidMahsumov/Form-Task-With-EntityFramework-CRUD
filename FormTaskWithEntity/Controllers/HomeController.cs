using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }
        [HttpPost]
        public IActionResult AddClient()
        {
            return RedirectToAction("Index","Register");
        }
        public IActionResult ShowAllClient()
        {
            return RedirectToAction("Index", "ShowAllClient");
        }
        public IActionResult RemoveClient()
        {
            return RedirectToAction("Index", "RemoveClient");
        }
        public IActionResult UpdateClient()
        {
            return RedirectToAction("Index", "UpdateClient");
        }
        public IActionResult GetClient()
        {
            return RedirectToAction("Index", "GetClient");
        }
    }
}
