using FormTaskWithEntity.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Controllers
{
    public class ShowAllClientController : Controller
    {
        private IRepository _repo;

        public ShowAllClientController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        [HttpPost]
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");

        }
    }

}
