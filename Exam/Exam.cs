public abstract class Exam
{
    private int time;

    public int Time
    {
        get { return time; }
        set
        {
            if (value < 30 || value > 180)
                throw new ArgumentException("Time must be between 30 and 180 minutes.");

            time = value;
        }
    }

    public int NumberOfQuestions { get; set; }
    public Question[] Questions { get; set; }

    public abstract void ShowExam();
}