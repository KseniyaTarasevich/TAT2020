using System;

namespace task_HW1
{

    public class Student : ITaskPerformer
    {
        private string _studentName;
        private string _studentSurname;
        public const int MIN_COUNT = 1;
        public const int MAX_COUNT = 10;

        public Student(string studentName, string studentSurname)
        {
            StudentName = studentName;
            StudentSurname = studentSurname;
        }

        public string StudentName
        {
            get
            {
                return _studentName;
            }

            set
            {
                _studentName = value;
            }
        }

        public string StudentSurname
        {
            get
            {
                return _studentSurname;
            }

            set
            {
                _studentSurname = value;
            }
        }

        public delegate void StudentTask(Student student, string str);

        public event StudentTask Notification;

        public string DoTask()
        {
            Notification?.Invoke(this, CreateRandomString());
            return CreateRandomString();
        }

        public static Random random = new Random((int)DateTime.Now.Ticks);

        public string CreateRandomString()
        {
            int size = random.Next(MIN_COUNT, MAX_COUNT);
            string answer = string.Empty;

            for (int i = 0; i < size; i++)
            {
                int value = random.Next(0, 127);
                answer += (char)value;
            }

            return answer;
        }
    }
}