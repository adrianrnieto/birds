using Birds.Server.Controllers;
using Birds.Server.Services;
using Birds.Shared;
using FluentAssertions;
using Moq;

namespace Birds.Unit.Tests.Controllers
{
    public class QuestionsControllerTests
    {
        private readonly Mock<IQuestionService> _questionService;

        private QuestionsController _controller;

        public QuestionsControllerTests()
        {
            _questionService = new Mock<IQuestionService>();
            _controller = new QuestionsController(_questionService.Object);
        }

        [Fact]
        public void QuestionsController_ForwardsResponseFromService()
        {
            // Arrange
            _questionService.Setup(s => s.GetRandom()).Returns(new Question());

            // Act
            var actual = _controller.Get();

            // Assert
            actual.Should().NotBeNull();
        }
    }
}
