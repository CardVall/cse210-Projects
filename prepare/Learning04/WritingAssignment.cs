using System;


class WritingAssignment : Assignment
{
    private string _title = "";
    private string _problems = "";

    public string GetTextbookSection()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }


    public WritingAssignment()
    {

    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}