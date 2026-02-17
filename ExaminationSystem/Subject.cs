using ExaminationSystem.Exam;
using ExaminationSystem.Validation;

namespace ExaminationSystem
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public BaseExam Exam { get; set; }


        public void CreateExam()
        {
            //3. create question , answers
            //4. show exam result

            //1. ask user for exam type (1.fianl , 2. practical)

            int examType = Validator.GetValidInt("Enter exam type (1. final, 2. practical): ", 1, 2);


            //2. ask user for (time, number of questions)
            //
            int time = Validator.GetValidInt("Enter exam time in minutes: ", 30, 120);
            int numberOfQuestions = Validator.GetValidInt("Enter number of questions: ", 1, 20);



            // base class => child class 
            //CLR will bind function call based on the object type [
            Exam = examType == 1 ? new FinalExam(time, numberOfQuestions)
                : new PracticalExam(time, numberOfQuestions);


            Exam.CreateQuestions();
        }
    }
}
