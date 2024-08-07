using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExplorandoCSharp.Models
{
    public class Course
    {
        //Propriedades
        public string Name { get; set; }
        public List<Person> Students { get; set; }

        //Métodos
        public void AddStudent(Person student)
        {
            Students.Add(student);
        }

        public int StudentsQuantity()
        {
            return Students.Count;
        }

        public bool RemoveStudent(Person student)
        {
            return Students.Remove(student);
        }

        public void GetStudents()
        {
            foreach(Person student in Students)
            {
                Console.WriteLine(student.CompleteName);
            }
        }
    }
}