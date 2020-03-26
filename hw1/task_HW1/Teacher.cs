using System;
using System.Collections.Generic;

namespace task_HW1
{
    class Teacher
    {
        public Teacher()
        {
            TaskResults = new List<string>();
        }

        public List<string> TaskResults { get; private set; }

        public void AcceptTheWork(Student student, string answer)
        {
            TaskResults.Add(student.StudentName + " " + student.StudentSurname + " " + answer);

            if (TaskResults.Count == Student.MAX_COUNT)
            {
                PrintStudentListToConsole();
            }
        }

        public void StudentWorkDone(Student student)
        {
            student.Notification += AcceptTheWork;
        }

        public void PrintStudentListToConsole()
        {
            foreach (string str in TaskResults)
            {
                Console.WriteLine(str);
            }
        }
    }
}
