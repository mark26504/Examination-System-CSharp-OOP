using ExaminationSystem.Validation;
using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // subject => exam => questions => answers
            //======================

            //subject => create exam
            // exam => create questions
            // question => answers

            Subject subject = new Subject(10, "Database");
            subject.CreateExam();

            int startExam = Validator.GetValidInt("Do you want to start the exam? (1. Yes, 2. No): ", 1, 2);

            if (startExam == 1)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.Exam.ShowExam();
                sw.Stop();

                Console.WriteLine($"You took {sw.ElapsedMilliseconds}");
            }
        }
    }
}
