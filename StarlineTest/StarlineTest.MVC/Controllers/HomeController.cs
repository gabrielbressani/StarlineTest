using AutoMapper;
using StarlineTest.Domain.Entities;
using StarlineTest.Domain.Interfaces;
using StarlineTest.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarlineTest.MVC.Controllers
{
    public class HomeController : Controller
    {
        protected IUserRepository UsuarioRepository { get; private set; }

        public HomeController(IUserRepository usuarioRepository)
        {
            UsuarioRepository = usuarioRepository;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}