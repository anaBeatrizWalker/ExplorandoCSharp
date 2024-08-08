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
            //Interpolação de strings
            Console.WriteLine($"Students of the course: {Name}");

            for(int count =0; count< Students.Count; count++)
            {
                //Concatenação de strings 
                string result = "Nº " + (count + 1) + " - " + Students[count].CompleteName;
                Console.WriteLine(result);
            }
        }
    }
}