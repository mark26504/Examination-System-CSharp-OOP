using ExaminationSystem.Question;
using ExaminationSystem.Validation;

namespace ExaminationSystem.Exam
{
    public class PracticalExam : BaseExam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }
        public override void CreateQuestions()
        {

            Questions = new MCQQuestions[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = CreateSignleQuestion(); // question basic data
                Questions[i].CreateAnswers();
            }
        }

        private MCQQuestions CreateSignleQuestion()
        {

            string header = Validator.GetValidString("Enter question header: ", 5, 50);
            string body = Validator.GetValidString("Enter question body: ", 10, 200);
            int mark = Validator.GetValidInt("Enter question mark: ", 1, 20);

            return new MCQQuestions(header, body, mark);
        }

        public override void ShowExam()
        {

            // show question , answer 
            // aks user for correct answer

            // question, correct answer , user answer 
            // dry
            List<int> userAnswersIds = GetUserAnswer();


            // Shows the right answer

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question: {Questions[i].Body}");
                // will thrw ex
                // 1,2,3,4
                // 0,1,2,3,
                Console.WriteLine($"Correct Answer : {Questions[i].Answers[Questions[i].CorrectAnswerId - 1]}");
                Console.WriteLine($"Your Answer : {Questions[i].Answers[userAnswersIds[i] - 1]}");
                Console.WriteLine();
                Console.WriteLine("-------------------------------");
                Console.WriteLine();


            }



        }
    }
}
