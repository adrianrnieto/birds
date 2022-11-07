using Birds.Server.Repositories;
using Birds.Shared;

namespace Birds.Server.Services
{
    public interface IQuestionService
    {
        Question GetRandom();
    }

    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public Question GetRandom()
        {
            return _questionRepository.GetRandom();
        }
    }
}
