
namespace ExaminationSystem
{
    public class Answer
    {
        public Answer(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public int Id { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
