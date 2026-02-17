using ExaminationSystem.Question;
using ExaminationSystem.Validation;

namespace ExaminationSystem.Exam
{
    internal class FinalExam : BaseExam
    {

        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }
        public override void CreateQuestions()
        {
            // 1. initalize questions array
            // tf, mcq
            //BaseQuestion question = new MCQQuestions(); ;

            Questions = new BaseQuestion[NumberOfQuestions]; //[mcq, tr, mcq]
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = CreateSignleQuestion(); // question basic data
                Questions[i].CreateAnswers();
            }
        }

        private BaseQuestion CreateSignleQuestion()
        {
            // 1. ask user for question type (1.MCQ, 2. True/False)
            int questionType = Validator.GetValidInt("Enter question type (1. MCQ, 2. True/False): ", 1, 2);

            // 2. question basic data (header, body, mark)
            string header = Validator.GetValidString("Enter question header: ", 5, 50);
            string body = Validator.GetValidString("Enter question body: ", 10, 200);
            int mark = Validator.GetValidInt("Enter question mark: ", 1, 20);

            return questionType == 1 ? new MCQQuestions(header, body, mark) :
                new TFQuestions(header, body, mark);
        }

        public override void ShowExam()
        {
            // print question , answer 


            List<int> userAnswersIds = GetUserAnswer();
            // ask user for choice id 

            /// after exam 
            /// show  Questions, Answers and Grade
            /// 80 of 100
            /// question, correct answer id => user answer id 
            int userTotalMarks = 0, questionTotalMarks = 0;
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i].ToString());
                Console.WriteLine();
                questionTotalMarks += Questions[i].Mark;
                userTotalMarks += Questions[i].CorrectAnswerId == userAnswersIds[i] ? Questions[i].Mark : 0;
            }
            Console.WriteLine($"Your mark is : {userTotalMarks} of {questionTotalMarks}");

        }
    } 
}
