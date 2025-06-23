public class Student
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Grade { get; set; }

    public Student(string name, string id, string grade)
    {
        Name = name;
        Id = id;
        Grade = grade;
    }
}
