public class StudentController
{
    private Student student;
    private StudentView view;

    public StudentController(Student student, StudentView view)
    {
        this.student = student;
        this.view = view;
    }

    public void SetStudentName(string name)
    {
        student.Name = name;
    }

    public string GetStudentName()
    {
        return student.Name;
    }

    public void SetStudentId(string id)
    {
        student.Id = id;
    }

    public string GetStudentId()
    {
        return student.Id;
    }

    public void SetStudentGrade(string grade)
    {
        student.Grade = grade;
    }

    public string GetStudentGrade()
    {
        return student.Grade;
    }

    public void UpdateView()
    {
        view.DisplayStudentDetails(student.Name, student.Id, student.Grade);
    }
}
