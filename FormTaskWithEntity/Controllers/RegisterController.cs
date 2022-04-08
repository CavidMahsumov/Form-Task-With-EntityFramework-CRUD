using FormTaskWithEntity.Model;
using FormTaskWithEntity.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Controllers
{
    public class RegisterController : Controller
    {
        private IRepository repository;

        public RegisterController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            ClientViewModel clientViewModel = new ClientViewModel()
            {
                Client = new Entities.Client()
            };
            return View(clientViewModel);
        }

        [HttpPost]
        public IActionResult Register(ClientViewModel clientViewModel)
        {
            repository.Add(clientViewModel.Client);
           

            return RedirectToAction("Index", "Home");
        }
    }
}
