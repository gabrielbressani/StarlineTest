using AutoMapper;
using StarlineTest.Application.Interface;
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
        public ActionResult Index()
        {
            return View();
        }
    }
}