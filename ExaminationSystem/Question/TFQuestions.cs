
using ExaminationSystem.Validation;

namespace ExaminationSystem.Question
{
    public class TFQuestions : BaseQuestion
    {
        public TFQuestions(string header, string body, int mark) : base(header, body, mark)
        {

        }

        public override void CreateAnswers()
        {
            Answers = new Answer[numberofTFAnswers];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
            CorrectAnswerId = Validator.GetValidInt("Enter the correct answer ID (1 for True, 2 for False): ", 1, numberofTFAnswers);

        }
    }
}
