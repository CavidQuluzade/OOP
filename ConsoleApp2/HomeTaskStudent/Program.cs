using HomeTaskStudent;
using Microsoft.VisualBasic;

Student student = new Student("Javid", "Qulu-zade");
Student student1= new Student("aaa", "bbb");
Student student2 = new Student("ccc", "ddd");

Teacher teacher = new Teacher("Kenan", "Tapdigli");
Teacher teacher1 = new Teacher("AAA", "BBB");
Teacher teacher2 = new Teacher("CCC", "DDD");

Topic topic = new Topic("C#");
Topic topic1 = new Topic("DataBase");
Topic topic2 = new Topic("Back-End");

Group studentGroup = new Group(602, 15, new DateTime(2024, 3, 30), new DateTime(2025, 2, 12));
studentGroup.AddStudent(student);
studentGroup.AddStudent(student1);
studentGroup.AddStudent(student2);
studentGroup.RemoveStudent(student1);
studentGroup.GetStudent();
studentGroup.AddTeacher(teacher);
studentGroup.AddTeacher(teacher1);
studentGroup.AddTeacher(teacher2);
studentGroup.RemoveTeacher(teacher1);
studentGroup.GetTeacher();
studentGroup.AddTopic(topic);
studentGroup.AddTopic(topic1);
studentGroup.AddTopic(topic2);
studentGroup.RemoveTopic(topic1);
studentGroup.GetTopic();
studentGroup.GetDetails();
