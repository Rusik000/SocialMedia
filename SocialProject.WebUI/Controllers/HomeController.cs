using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SocialProject.Business.Abstract;
using SocialProject.WebUI.Entities;
using SocialProject.WebUI.Helpers;
using SocialProject.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialProject.WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IHttpContextAccessor _httpContext;
        private UserManager<CustomIdentityUser> _userManager;
        private readonly IWebHostEnvironment _webhost;

        public HomeController(IUserService userService, IHttpContextAccessor httpContext, UserManager<CustomIdentityUser> userManager, IWebHostEnvironment webhost)
        {
            _userService = userService;
            _httpContext = httpContext;
            _userManager = userManager;
            _webhost = webhost;
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


        public async Task<IActionResult> AccountInformation()
        {
            var userId = _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);

            var model = new AccountInfoViewModel
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Email = user.Email,
                Address = user.Address,
                City = user.City,
                Country = user.Country,
                Phone = user.PhoneNumber,
                PostCode = user.PostCode,
                ImagePath = user.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AccountInformation(AccountInfoViewModel model)
        {
            var userId = _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            if (model.File != null)
            {
                var Helper = new ImageHelper(_webhost);
                model.ImagePath = await Helper.SaveFile(model.File);
            }

            user.Firstname = model.Firstname;
            user.Lastname = model.Lastname;
            user.Email = model.Email;
            user.Address = model.Address;
            user.PhoneNumber = model.Phone;
            user.Country = model.Country;
            user.City = model.City;
            user.PostCode = model.PostCode;
            if (model.ImagePath != null)
            {
                user.ImageUrl = model.ImagePath;
            }
            await _userManager.UpdateAsync(user);
            return RedirectToAction("AccountInformation");
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
