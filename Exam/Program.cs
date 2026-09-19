using System;
using System.Diagnostics;

internal class Program
{
    static void Main()
    {
        Subject sub1 = new Subject();

        sub1.CreateExam();

        Console.Clear();

        Console.Write("Do You Want To Start The Exam (Y | N) : ");
        char choice = char.Parse(Console.ReadLine());

        if (choice == 'y' || choice == 'Y')
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            sub1.Exam.ShowExam();

            sw.Stop();

            Console.WriteLine();
            Console.WriteLine($"What Time You Are Take = {sw.Elapsed}");
        }
    }
}