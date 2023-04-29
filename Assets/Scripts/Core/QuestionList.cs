using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;

namespace Assets.Scripts.Core
{
    public class QuestionList
    {
        public static List<Question> _questions = new()
        {
            new Question { Description = "Светит, сверкает, всех согревает", Answer = "СОЛНЦЕ" },
            new Question { Description = "Не простые туфли эти, в них танцуют лишь в балете", Answer = "ПУАНТЫ" },
            new Question { Description = "Он в моём новогоднем подарке сияет солнцем ярким, и такой исходит аромат, аромат, будто рядом дивный сад", Answer = "МАНДАРИН" },
            new Question { Description = "Число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях", Answer = "ПАЛИНДРОМ" },
            new Question { Description = "Наука, изучающая прошлое человечества по вещественным источникам", Answer = "АРХЕОЛОГИЯ" },
            new Question { Description = "Небрежно написанные, неразборчивые, плохо читаемые и трудно разбираемые слова или цифры", Answer = "КАРАКУЛИ" },
            new Question { Description = "Брождение во сне", Answer = "ЛУНАТИЗМ" },
            new Question { Description = "Медицинское учреждение, осуществляющее внебольничное лечебно-профилактическое обслуживание населения", Answer = "ПОЛИКЛИНИКА" },
            new Question { Description = "Миниатюрная лисица с крупными относительно тела ушами, живущая в пустыне", Answer = "ФЕНЕК" },
            new Question { Description = "Таинственный убийца, живущий в засекреченных логовах и беспрекословно подчиняющийся приказам своего мастера", Answer = "АССАСИН" },
            new Question { Description = "Самая популярная командная игра в мире", Answer = "ФУТБОЛ"},
            new Question { Description = "\"Лучше быть абсолютно смешной, чем быть абсолютно ...\", - Мерлин Монро", Answer = "СКУЧНОЙ"},
            new Question { Description = "Какая война длилась 116 лет", Answer = "СТОЛЕТНЯЯ" },
        };

        public static List<Question> _sienceQuestions = new()
        {
            new Question { Description = "Наука, изучающая прошлое человечества по вещественным источникам", Answer = "АРХЕОЛОГИЯ" },
        };

        public static List<Question> _historyQuestions = new()
        {
            new Question { Description = "Какая война длилась 116 лет", Answer = "СТОЛЕТНЯЯ" },
        };

        public static List<Question> _artQuestions = new()
        {
            new Question { Description = "Не простые туфли эти, в них танцуют лишь в балете", Answer = "ПУАНТЫ" },
        };

        public static List<Question> _liveworldQuestions = new()
        {
            new Question { Description = "Миниатюрная лисица с крупными относительно тела ушами, живущая в пустыне", Answer = "ФЕНЕК" },
        };

        public static List<Question> _movieQuestions = new()
        {
            new Question { Description = "Таинственный убийца, живущий в засекреченных логовах и беспрекословно подчиняющийся приказам своего мастера", Answer = "АССАСИН" },
        };

        public static List<Question> _sportQuestions = new()
        {
            new Question { Description = "Самая популярная командная игра в мире", Answer = "ФУТБОЛ"}
        };

        public static List<Question> _finishsentenceQuestions = new()
        {
            new Question { Description = "\"Лучше быть абсолютно смешной, чем быть абсолютно ...\", - Мерлин Монро", Answer = "СКУЧНОЙ"}
        };
    }
}
