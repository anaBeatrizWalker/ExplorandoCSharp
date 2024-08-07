using ExplorandoCSharp.Models;


Person p = new Person();
p.Name="Ana";
p.Surname="Walker";
p.Age=20;
// p.IntroduceYourself();

Person p2 = new Person();
p2.Name="Gustavo";
p2.Surname="Santos";
p2.Age=20;

Course englishCourse = new Course();
englishCourse.Name = "Basic English Course";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p);
englishCourse.AddStudent(p2);
englishCourse.GetStudents();
Console.WriteLine($"Current students quantity: {englishCourse.StudentsQuantity()}");

englishCourse.RemoveStudent(p2);
englishCourse.GetStudents();
Console.WriteLine($"Current students quantity: {englishCourse.StudentsQuantity()}");
