using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public  int Age { get => ((int)((DateTime.Now - BirthDate).TotalDays / 365)); }

        public List<Subject> Subjects { get; set; } = new List<Subject>();
        

    }
}
    