using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesTransaction.Application.Models;

namespace SalesTransaction.Application.WebApi.Controllers
{
    public class UserLoginController : Controller
    {
        private readonly ApplicationUserClass _auc;

        public UserLoginController(ApplicationUserClass auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UsersClass uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The User" + uc.UserName + "is Saved Successfully!";
            return View();
        }

    }
}
