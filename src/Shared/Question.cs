namespace Birds.Shared
{
    public class Question
    {
        public string ImageUrl { get; set; } = default!;
        public IList<string> Answers { get; set; } = default!;
        public string CorrectAnswer { get; set; } = default!;
        public Difficulties Difficulty { get; set; }
    }
}
