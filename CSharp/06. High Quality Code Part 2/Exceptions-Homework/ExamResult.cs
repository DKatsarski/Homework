using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("Grade cannot be lower then zero!");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("Min grade cannot be lower then zero!");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("maxGrade cannot be lower or equal to minGrade");
        }

        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("Comments cannot be null or empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
