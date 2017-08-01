using StarlineTest.Application.Interface;
using StarlineTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StarlineTest.API.Controllers
{
    [Route("api/Questions")]
    public class QuestionsController : ApiController
    {
        protected IQuestionAppService QuestionAppService { get; private set; }

        public QuestionsController(IQuestionAppService questionAppService)
        {
            QuestionAppService = questionAppService;
        }

        // GET apli/Questions
        public Question[] Get()
        {
            return QuestionAppService.GetAll().ToArray();
        }

        // GET apli/Questions/5
        public string Get(int id)
        {
            return QuestionAppService.GetById(id).Answers;
        }

    }
}
