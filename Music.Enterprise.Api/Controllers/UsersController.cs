using Music.Enterprise.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.Enterprise.Api.Controllers
{
    public class UsersController : Controller
    {

        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }  
        
        // GET: Users
        public ActionResult Index()
        {

            var lista = _userService.ObtenerTodos();

            return View(lista);
        }
    }
}