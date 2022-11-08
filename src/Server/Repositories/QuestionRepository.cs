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
                CorrectAnswer = "Gaviota",
                Difficulty = 2
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
                CorrectAnswer = "Cuervo",
                Difficulty = 0
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
                CorrectAnswer = "Estornino",
                Difficulty = 1
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
                CorrectAnswer = "Gorrión",
                Difficulty = 1
            },
            new Question
            {
                ImageUrl = "https://img.lovepik.com/photo/20211201/medium/lovepik-parrot-picture_501344196.jpg",
                Answers = new List<string>
                {
                    "Gorrión",
                    "Estornino",
                    "Gaviota",
                    "Loro"
                },
                CorrectAnswer = "Loro",
                Difficulty = 0
            },
            new Question
            {
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2a/Paloma_domestica_-_paloma_brav%C3%ADa_%28Columba_livia%29_refrescandose_en_un_charco_de_agua.JPG",
                Answers = new List<string>
                {
                    "Gorrión",
                    "Paloma",
                    "Gaviota",
                    "Cuervo"
                },
                CorrectAnswer = "Paloma",
                Difficulty = 2
            },
            new Question
            {
                ImageUrl = "https://farm8.staticflickr.com/7078/7190409204_2ded47622e_b.jpg",
                Answers = new List<string>
                {
                    "Gorrión",
                    "Estornino",
                    "Buho",
                    "Cuervo"
                },
                CorrectAnswer = "Buho",
                Difficulty = 1
            },
        };

        public Question GetRandom()
        {
            return _questions[_random.Next(0, _questions.Count)];
        }
    }
}
