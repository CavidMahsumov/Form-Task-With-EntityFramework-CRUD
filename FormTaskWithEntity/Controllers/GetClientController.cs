using FormTaskWithEntity.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Controllers
{
    public class GetClientController : Controller
    {
        private IRepository _repo;

        public GetClientController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return (IActionResult)View(_repo.GetAll());
        }
        public IActionResult GetClient(int id)
        {
            return View(_repo.Get(id));
        }
        public IActionResult GoBack()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
