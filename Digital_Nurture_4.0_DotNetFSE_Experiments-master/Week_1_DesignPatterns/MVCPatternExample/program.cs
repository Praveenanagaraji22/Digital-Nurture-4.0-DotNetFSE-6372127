using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Jeeva", "1001", "A");
        StudentView view = new StudentView();
        StudentController controller = new StudentController(student, view);

        controller.UpdateView();

        controller.SetStudentName("Priya");
        controller.SetStudentGrade("A+");
        controller.UpdateView();
    }
}
