using System.Collections.Generic;

namespace Birds.Shared
{
    public class Question
    {
        public string ImageUrl { get; set; }
        public IList<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }
        public Difficulties Difficulty { get; set; }
    }
}
