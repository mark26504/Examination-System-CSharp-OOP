using System.Text;

namespace ExaminationSystem.Question
{
    public abstract class BaseQuestion
    {
        protected int numberofMCQAnswers = 4; // default number of answers for MCQ questions
        protected int numberofTFAnswers = 2; // default number of answers for True/False questions
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public BaseQuestion(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }


        public Answer[] Answers { get; set; }

        public int CorrectAnswerId { get; set; }

        // create answers

        public abstract void CreateAnswers();


        public override string ToString()
        {
            StringBuilder sb = new($"Header: {Header}\n Body: {Body}\nMark: {Mark}\nAnswers:\n");
            for (int i = 0; i < Answers.Length; i++)
            {
                sb.Append($"{Answers[i].Id}. {Answers[i].Text}\n");
            }
            return sb.ToString();
        }
    }
}
