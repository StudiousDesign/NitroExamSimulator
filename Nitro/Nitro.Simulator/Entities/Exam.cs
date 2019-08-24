using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nitro.Simulator.Entities
{
    public class Exam
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public Guid Id { get; set; }
        public bool IsMultiSelection { get; set; }
        public string QuestionText { get; set; }
        public AnswerOption[] AnswerOptions { get; set; }
    }

    public class AnswerOption
    {
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
    }
}
