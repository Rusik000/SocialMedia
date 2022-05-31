using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using SocialProject.WebUI.Entities;
using SocialProject.WebUI.Helpers;
using SocialProject.WebUI.Models;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialProject.WebUI.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private UserManager<CustomIdentityUser> _userManager;
        private IHttpContextAccessor _httpContext;

        public ContactViewComponent(UserManager<CustomIdentityUser> userManager, IHttpContextAccessor httpContext)
        {
            _userManager = userManager;
            _httpContext = httpContext;
        }

        public async Task<ViewViewComponentResult> InvokeAsync()
        {
            var users = _userManager.Users;

            var currentUser = await GetUser();

            var model = new ContactViewModel
            {
                Friends = users.Where(u => u.Id != currentUser.Id).ToList(),
            };


            return View(model);

        }

        public async Task<CustomIdentityUser> GetUser()
        {
            var userId = _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            return user;
        }

    }
}
