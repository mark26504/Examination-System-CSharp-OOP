
using ExaminationSystem.Validation;

namespace ExaminationSystem.Question
{
    public class MCQQuestions : BaseQuestion
    {
        public MCQQuestions(string header, string body, int mark) : base(header, body, mark)
        {

        }

        public override void CreateAnswers()
        {
            Answers = new Answer[numberofMCQAnswers];
            for (int i = 0; i < Answers.Length; i++)
            {
                string answerText = Validator.GetValidString($"Enter answer {i + 1} text: ", 5, 100);
                Answers[i] = new Answer(i + 1, answerText);
            }
            CorrectAnswerId = Validator.GetValidInt("Enter the correct answer ID: ", 1, numberofMCQAnswers);

        }
    }
}
