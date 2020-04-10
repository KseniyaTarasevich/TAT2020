using System.Collections.Generic;

namespace task_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

            List<Student> students = new List<Student>();

            for (int i = Student.MIN_COUNT; i <= Student.MAX_COUNT; i++)
            {
                students.Add(new Student("Name " + i, "Surname " + i));
            }

            foreach (Student student in students)
            {
                teacher.StudentWorkDone(student);
            }

            foreach (Student student in students)
            {
                student.DoTask();
            }
        }
    }
}