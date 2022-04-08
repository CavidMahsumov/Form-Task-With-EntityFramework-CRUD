using FormTaskWithEntity.Entities;
using FormTaskWithEntity.Helper.StaticClasses;
using FormTaskWithEntity.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Controllers
{
    public class UpdateClientController : Controller
    {
        private IRepository _repo;

        public UpdateClientController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
     
        public IActionResult FindClient1(int id)
        {
            ClientHelper.IdForUpdate = id;
            return View(_repo.Get(id));
        }
        [HttpPost]
        public IActionResult FindClient(Client client)
        {
            _repo.Update(ClientHelper.IdForUpdate, client);
            return RedirectToAction("Index", "Home");
            
        }
    }
}
