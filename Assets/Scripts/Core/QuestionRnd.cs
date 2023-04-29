using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;

namespace Assets.Scripts.Core
{
    public class QuestionRnd
    {
        public Question question = new();
#nullable enable
        public string? CurrentDescription { get; set; }
        public string? CurrentAnswer { get; set; }
#nullable disable
        public QuestionRnd(string topic) 
        {
            Random rnd = new();
            int number;
            switch (topic)
            {
                case "Наука":
                    number = rnd.Next(QuestionList._sienceQuestions.Count);
                    question = QuestionList._sienceQuestions[number];
                    break;
                case "История":
                    number = rnd.Next(QuestionList._historyQuestions.Count);
                    question = QuestionList._historyQuestions[number];
                    break;
                case "Искусство":
                    number = rnd.Next(QuestionList._artQuestions.Count);
                    question = QuestionList._artQuestions[number];
                    break;
                case "Живой мир":
                    number = rnd.Next(QuestionList._liveworldQuestions.Count);
                    question = QuestionList._liveworldQuestions[number];
                    break;
                case "Кино":
                    number = rnd.Next(QuestionList._movieQuestions.Count);
                    question = QuestionList._movieQuestions[number];
                    break;
                case "Спорт":
                    number = rnd.Next(QuestionList._sienceQuestions.Count);
                    question = QuestionList._sportQuestions[number];
                    break;
                case "Закончи фразу":
                    number = rnd.Next(QuestionList._finishsentenceQuestions.Count);
                    question = QuestionList._finishsentenceQuestions[number];
                    break;
                case "Случайные":
                    number = rnd.Next(QuestionList._questions.Count);
                    question = QuestionList._questions[number];
                    break;
            }
            /*var number = rnd.Next(QuestionList._questions.Count);
            question = QuestionList._questions[number];*/
            CurrentDescription = question.Description;
            CurrentAnswer = question.Answer;
        } 
    }
}
