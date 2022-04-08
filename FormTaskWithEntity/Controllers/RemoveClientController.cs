using FormTaskWithEntity.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Controllers
{
    public class RemoveClientController : Controller
    {
        private IRepository _repo;

        public int id = 0;
        public RemoveClientController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Remove(int id)
        {
            
            _repo.Delete(id);
            
            return RedirectToAction("Index", "Home");
        }
    }
}
