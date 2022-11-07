using Birds.Server.Services;
using Birds.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Birds.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public Question Get()
        {
            return _questionService.GetRandom();
        }
    }
}
