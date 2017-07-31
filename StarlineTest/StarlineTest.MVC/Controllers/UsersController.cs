using AutoMapper;
using StarlineTest.Application.Interface;
using StarlineTest.Domain.Entities;
using StarlineTest.MVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StarlineTest.MVC.Controllers
{
    public class UsersController : Controller
    {
        protected IUserAppService UserAppService { get; private set; }

        public UsersController(IUserAppService userAppService)
        {
            UserAppService = userAppService;
        }

        public ActionResult Index()
        {
            var userViewModel = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(UserAppService.GetAll());

            if (Request.IsAjaxRequest())
                return PartialView(userViewModel);

            return View(userViewModel);
        }

        public ActionResult Create()
        {
            return PartialView("CreateEdit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<UserViewModel, User>(userViewModel);
                UserAppService.Add(user);

                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            }

            return PartialView("CreateEdit", userViewModel);
        }

        public ActionResult Edit(int id)
        {
            var userViewModel = Mapper.Map<User, UserViewModel>(UserAppService.GetById(id));

            return PartialView("CreateEdit", userViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<UserViewModel, User>(userViewModel);
                UserAppService.Update(user);

                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            }

            return PartialView("CreateEdit", userViewModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var user = UserAppService.GetById(id);
            UserAppService.Remove(user);

            return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}