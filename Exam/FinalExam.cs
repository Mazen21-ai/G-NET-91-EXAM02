
using System;

namespace ExamSystem
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public override void ShowExam()
        {
            int grade = 0;
            int totalGrade = 0;

            int[] studentAnswers = new int[Questions.Length];

            Console.WriteLine("Final Exam Results:");
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine("Question " + (i + 1) + ": " + question.Body);

                for (int j = 0; j < question.Answers.Length; j++)
                {
                    Console.WriteLine(
                        question.Answers[j].AnswerId + ". " +
                        question.Answers[j].AnswerText);
                }

                Console.Write("Your Answer => ");
                int studentAnswer = int.Parse(Console.ReadLine());

                studentAnswers[i] = studentAnswer;

                if (studentAnswer == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                totalGrade += question.Mark;

                Console.WriteLine();
            }

            Console.WriteLine("Your Grade is " + grade + " from " + totalGrade);
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine("Question " + (i + 1));

                Console.WriteLine(
                    "Your Answer => " +
                    Questions[i].Answers[studentAnswers[i] - 1].AnswerText);

                Console.WriteLine(
                    "Correct Answer => " +
                    Questions[i].RightAnswer.AnswerText);

                Console.WriteLine();
            }
        }
    }
}