using ExplorandoCSharp.Models;


Person p = new Person(name:"Ana", surname:"Walker");
// p.IntroduceYourself();

Person p2 = new Person(name: "Gustavo", surname: "Santos");

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
