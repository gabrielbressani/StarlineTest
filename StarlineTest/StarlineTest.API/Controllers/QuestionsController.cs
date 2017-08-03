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
    public class QuestionsController : ApiController
    {
        protected IQuestionAppService QuestionAppService { get; private set; }

        public QuestionsController(IQuestionAppService questionAppService)
        {
            QuestionAppService = questionAppService;
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            var question = QuestionAppService.GetById(id);

            return Ok(new {
                QuestionId = question.QuestionId,
                TypeOfQuestion = question.TypeOfQuestion,
                Enunciated = question.Enunciated,
                Answers = question.Answers
            });
        }
    }
}
