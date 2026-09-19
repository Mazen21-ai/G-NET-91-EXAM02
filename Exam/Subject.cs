using ExamSystem;
using System;

public class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public Exam Exam { get; set; }

    public Subject()
    {
    }

    public void CreateExam()
    {
        Console.Write("Enter the Type of Exam (1 For Practical, 2 for Final): ");
        int examType = int.Parse(Console.ReadLine());

        Console.Write("Please Enter Exam Time(From 30 To 180 Mintes): ");
        int time = int.Parse(Console.ReadLine());

        Console.Write("Please Enter Number of Questions: ");
        int numberOfQuestions = int.Parse(Console.ReadLine());

        if (examType == 1)
        {
            Exam = new PracticalExam(time, numberOfQuestions);
        }
        else
        {
            Exam = new FinalExam(time, numberOfQuestions);
        }

        Question[] questions = new Question[numberOfQuestions];

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.Clear();

            if (examType == 2)
            {
                Console.Write("Please Enter Question Type (1 for True/False, 2 for MCQ): ");
                int questionType = int.Parse(Console.ReadLine());

                Console.Write("Please Enter The Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Please Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());

                if (questionType == 1)
                {
                    TorFQuestion question =
                        new TorFQuestion("True/False", body, mark);

                    Answer[] answers =
                    {
                        new Answer(1, "True"),
                        new Answer(2, "False")
                    };

                    question.Answers = answers;

                    Console.Write("Please Enter Correct Answer Number (1-2): ");
                    int correctAnswer = int.Parse(Console.ReadLine());

                    question.RightAnswer = answers[correctAnswer - 1];

                    questions[i] = question;
                }
                else
                {
                    MCQQuestion question =
                        new MCQQuestion("MCQ", body, mark);

                    Answer[] answers = new Answer[4];

                    Console.WriteLine();
                    Console.WriteLine("Question: " + body);
                    Console.WriteLine("Choices:");

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("Please Enter Choice " + (j + 1) + ": ");
                        string answerText = Console.ReadLine();

                        answers[j] = new Answer(j + 1, answerText);
                    }

                    question.Answers = answers;

                    Console.Write("Please Enter Correct Answer Number (1-4): ");
                    int correctAnswer = int.Parse(Console.ReadLine());

                    question.RightAnswer = answers[correctAnswer - 1];

                    questions[i] = question;
                }
            }
            else
            {
                Console.Write("Please Enter The Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Please Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());

                MCQQuestion question =
                    new MCQQuestion("MCQ", body, mark);

                Answer[] answers = new Answer[4];

                Console.WriteLine();
                Console.WriteLine("Question: " + body);
                Console.WriteLine("Choices:");

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Please Enter Choice " + (j + 1) + ": ");
                    string answerText = Console.ReadLine();

                    answers[j] = new Answer(j + 1, answerText);
                }

                question.Answers = answers;
                Console.Write("Please Enter Correct Answer Number (1-4): ");
                int correctAnswer = int.Parse(Console.ReadLine());

                question.RightAnswer = answers[correctAnswer - 1];

                questions[i] = question;
            }

            if (i < numberOfQuestions - 1)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue to the next question...");
                Console.ReadLine();
            }
        }

        Exam.Questions = questions;
    }
}