using Birds.Server.Repositories;

namespace Birds.Unit.Tests.Repositories
{
    public class QuestionRepositoryTest
    {
        private QuestionRepository _repository;

        public QuestionRepositoryTest()
        {
            _repository= new QuestionRepository();
        }

        [Fact]
        public void GetRandom_ReturnsRandomQuestion()
        {
            //Arrange

            //Act
            var actual = _repository.GetRandom();

            //Assert
            actual.ImageUrl.Should().NotBeEmpty();
            actual.Answers.Should().HaveCount(4);
            actual.CorrectAnswer.Should().NotBeEmpty();
        }
    }
}
