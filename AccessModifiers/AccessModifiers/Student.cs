using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Speciality { get; set; }


        public Student()
        {

        }




        public Student(int id , string name ,string surName , string speciality)
        {
            Name = name;
            Id = id;
            SurName = surName;
            Speciality = speciality;
        }
        
    }
}
