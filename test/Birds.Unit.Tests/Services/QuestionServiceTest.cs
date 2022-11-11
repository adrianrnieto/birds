using Birds.Server.Repositories;
using Birds.Server.Services;

namespace Birds.Unit.Tests.Services
{
    public class QuestionServiceTest
    {
        private readonly Mock<IQuestionRepository> _questionRepository;
        private QuestionService _service;

        public QuestionServiceTest()
        {
            _questionRepository = new Mock<IQuestionRepository>();
            _service = new QuestionService(_questionRepository.Object);
        }

        [Fact]
        public void QuestionService_ForwardsResponseFromRepository()
        {
            //Arrange
            _questionRepository.Setup(s => s.GetRandom()).Returns(new Question());

            //Act
            var actual = _service.GetRandom();

            //Assert
            actual.Should().NotBeNull();
        }

    }
}
