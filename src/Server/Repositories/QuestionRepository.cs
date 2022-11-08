using Birds.Shared;
using System;
using System.Collections.Generic;

namespace Birds.Server.Repositories
{
    public interface IQuestionRepository
    {
        Question GetRandom();
    }

    public class QuestionRepository : IQuestionRepository
    {
        private readonly Random _random = new();
        private readonly IList<Question> _questions = new List<Question>
        {
            new Question
            {
                ImageUrl = "https://static9.depositphotos.com/1594920/1087/i/600/depositphotos_10875506-stock-photo-herring-gull-larus-argentatus-3.jpg",
                Answers = new List<string>
                {
                    "Gorrión",
                    "Estornino",
                    "Gaviota",
                    "Cuervo"
                },
                CorrectAnswer = "Gaviota"
            },
            new Question
            {
                ImageUrl = "https://nas-national-prod.s3.amazonaws.com/styles/api_hero_bird_with_crop_1920_1200/public/birds/hero_image/apa_2011_20017_158283_warrenlynn_chihuahuan_raven_kk_adult.jpg",
                Answers = new List<string>
                {
                    "Gorrión",
                    "Estornino",
                    "Gaviota",
                    "Cuervo"
                },
                CorrectAnswer = "Cuervo"
            },
            new Question
            {
                ImageUrl = "https://ichef.bbci.co.uk/news/640/cpsprodpb/13F68/production/_117886718_gettyimages-866048120.jpg",
                Answers = new List<string>
                {
                    "Gorrión",
                    "Estornino",
                    "Gaviota",
                    "Cuervo"
                },
                CorrectAnswer = "Estornino"
            },
            new Question
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/df/Huismus%2C_man.jpg/1920px-Huismus%2C_man.jpg",
                Answers = new List<string>
                {
                    "Gorrión",
                    "Estornino",
                    "Gaviota",
                    "Cuervo"
                },
                CorrectAnswer = "Gorrión"
            },
        };

        public Question GetRandom()
        {
            return _questions[_random.Next(0, _questions.Count)];
        }
    }
}
