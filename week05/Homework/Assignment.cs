public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // This method is added to allow derived classes to access the student name
    // It is not part of the original code but is necessary for WritingAssignment
    public string GetStudentName()
    {
        return _studentName;
    }
}
