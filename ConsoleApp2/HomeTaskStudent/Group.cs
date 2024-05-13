using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent
{
    internal class Group
    {
        public int GroupNO { get; set; }
        public int Limit { get; } = 15;
        public DateTime DateTime { get; set; }
        public DateTime EndTime { get; set; }
        private Student[] students;
        private Teacher[] teachers;
        private Topic[] topics;
        public Topic[] Topics;
        public Teacher[] Teachers { get { return teachers; } }
        public Student[] Students { get { return students; } }
        
        public Group(int groupNO, int limit, DateTime dateTime, DateTime endTime)
        {
            GroupNO = groupNO;
            Limit = limit;
            DateTime = dateTime;
            EndTime = endTime;
            students = new Student[0];
            teachers = new Teacher[0];
            topics = new Topic[0];
        }
        public void AddStudent(Student student)
        {
            if (Limit > students.Length)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length-1]= student;

            }
            else
            {
                Console.WriteLine("You have students more than 15");
            }
        }
        public void GetStudent()
        {
            foreach (var student in students)
            {
                student.GetStudentDetail();
            }
        }
        public void RemoveStudent(Student student)
        {
            var index = Array.IndexOf(students, student);
            if (index != -1)
            {
                for (int i = index; i < students.Length - 1; i++)
                {
                    students[i] = students[i + 1];
                    Array.Resize(ref students, students.Length - 1);
                }
            }
            else
            {
                Console.WriteLine("You don;t have this student in this group");
            }
        }
        public void GetDetails()
        {
            Console.WriteLine($"Group - {GroupNO} Limit - {Limit} FirstLesson - {DateTime.ToString("dd/MM/yyyy")} LastLesson - {EndTime.ToString("dd/MM/yyyy")} ");

        }
        public void AddTeacher(Teacher teacher)
        {
            Array.Resize(ref teachers, teachers.Length + 1);
            teachers[teachers.Length - 1] = teacher;  
        }
        public void GetTeacher()
        {
            foreach(var teacher in teachers)
            {
                teacher.GetTeacherDetail();
            }
        }
        public void RemoveTeacher(Teacher teacher)
        {
            var index = Array.IndexOf(teachers, teacher);
            if (index != -1)
            {
                for (int i = index; i < teachers.Length - 1; i++)
                {
                    teachers[i] = teachers[i + 1];
                    Array.Resize(ref teachers, teachers.Length - 1);
                }
            }
            else
            {
                Console.WriteLine("You don;t have this teacher in this group");
            }
        }
        public void AddTopic(Topic topic)
        {
            Array.Resize(ref topics, topics.Length + 1);
            topics[topics.Length - 1] = topic;    
        }
        public void GetTopic()
        {
            foreach (var topic in topics)
            {
                topic.GetTopicDetail();
            }
        }
        public void RemoveTopic(Topic topic)
        {
            var index = Array.IndexOf(topics, topic);
            if (index != -1)
            {
                for (int i = index; i < topics.Length - 1; i++)
                {
                    topics[i] = topics[i + 1];
                    Array.Resize(ref topics, topics.Length - 1);
                }
            }
            else
            {
                Console.WriteLine("You don;t have this topic in this group");
            }
        }

    }
}
