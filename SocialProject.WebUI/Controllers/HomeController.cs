﻿using Microsoft.AspNetCore.Mvc;
using SocialProject.Business.Abstract;
using SocialProject.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialProject.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Badge()
        {
            return View();
        }


        public IActionResult Story()
        {
            return View();
        }

        public IActionResult Group()
        {
            return View();
        }
        public IActionResult UserPage()
        {
            return View();
        }

        public IActionResult Email()
        {
            return View();
        }
        public IActionResult Hotel()
        {
            return View();
        }

        public IActionResult Event()
        {
            return View();
        }

        public IActionResult Live()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

        public IActionResult Analytics()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }
        public IActionResult Video()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }


        public IActionResult AccountInformation()
        {
            return View();
        }


        public IActionResult ContactInformation()
        {
            return View();

        }

        public IActionResult Social()
        {
            return View();

        }

        public IActionResult Payment()
        {
            return View();

        }

        [HttpGet]
        public IActionResult Password()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Password(ChangePasswordViewModel model)
        {
            var users = _userService.GetAll();
            foreach (var user in users)
            {
                if (user.Password == model.CurrentPassword)
                {
                    if (model.NewPassword == model.ConfirmNewPassword)
                    {
                        user.Password = model.NewPassword;
                        return RedirectToAction("LogIn", "Account");
                    }
                }
            }
            return View(model);

        }

        public IActionResult Notification()
        {
            return View();
        }

        public IActionResult HelpBox()
        {
            return View();
        }

        public IActionResult SingleProduct()
        {
            return View();
        }
        public IActionResult Member()
        {
            return View();
        }


        public IActionResult OpenEmail()
        {
            return View();
        }


        public IActionResult HotelDetails()
        {
            return View();
        }


    }
}
