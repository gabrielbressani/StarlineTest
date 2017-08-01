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
    public class QuestionsController : Controller
    {
        protected IQuestionAppService QuestionAppService { get; private set; }
        protected IUserAppService UserAppService { get; private set; }

        public QuestionsController(IQuestionAppService questionAppService,
            IUserAppService userAppService)
        {
            QuestionAppService = questionAppService;
            UserAppService = userAppService;
        }

        public ActionResult Index(int userId)
        {
            var userViewModel = Mapper.Map<User, UserViewModel>(UserAppService.GetById(userId));

            if (Request.IsAjaxRequest())
                return PartialView(userViewModel);

            return View(userViewModel);
        }

        public ActionResult Create(int userId)
        {
            var questionViewModel = new QuestionViewModel(userId);

            return PartialView("CreateEdit", questionViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QuestionViewModel questionViewModel)
        {
            if (ModelState.IsValid)
            {
                var question = Mapper.Map<QuestionViewModel, Question>(questionViewModel);
                QuestionAppService.Add(question);

                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            }

            return PartialView("CreateEdit", questionViewModel);
        }
    }
}