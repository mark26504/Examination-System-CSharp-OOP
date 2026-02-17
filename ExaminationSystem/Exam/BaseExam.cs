using ExaminationSystem.Question;
using ExaminationSystem.Validation;

namespace ExaminationSystem.Exam
{
    public abstract class BaseExam
    {
        protected BaseExam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public BaseQuestion[] Questions { get; set; } // null 

        protected List<int> GetUserAnswer()
        {
            List<int> userAnswersIds = new();
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i].ToString());
                Console.WriteLine();
                int userAnswerId = Validator.GetValidInt(message: "Enter your choice ID: ", 1, Questions[i].Answers.Length);
                userAnswersIds.Add(userAnswerId);
            }
            return userAnswersIds;
        }

        public abstract void ShowExam();
        public abstract void CreateQuestions();


    }
}
