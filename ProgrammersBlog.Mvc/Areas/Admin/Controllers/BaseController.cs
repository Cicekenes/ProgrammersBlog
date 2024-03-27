using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.Helpers.Abstract;

namespace ProgrammersBlog.Mvc.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public BaseController(UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper)
        {
            _userManager = userManager;
            _mapper = mapper;
            _imageHelper = imageHelper;
        }

        protected UserManager<User> _userManager { get; }
        protected IMapper _mapper { get; }
        protected IImageHelper _imageHelper { get; }
        protected User LoggedInUser => _userManager.GetUserAsync(HttpContext.User).Result;

    }
}
