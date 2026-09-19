using System;

public class Question : ICloneable, IComparable
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Mark { get; set; }

    public Answer[] Answers { get; set; }
    public Answer RightAnswer { get; set; }

    public Question() : this("", "", 0)
    {
    }

    public Question(string header, string body, int mark)
    {
        Header = header;
        Body = body;
        Mark = mark;
    }

    public object Clone()
    {
        return MemberwiseClone();
    }

    public int CompareTo(object obj)
    {
        Question other = obj as Question;

        if (other == null)
            return 1;

        return Mark.CompareTo(other.Mark);
    }

    public override string ToString()
    {
        return Header + ": " + Body;
    }
}