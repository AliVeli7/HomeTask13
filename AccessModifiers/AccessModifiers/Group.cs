using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Group
    {
        public string Name { get; set; }
        public int MaxCount { get; set; }
        public Student[] Students { get; set; }
        Student[] students = new Student[1];

        public Group()
        {

        }


        public Group(string name, int maxCount)
        {
            Name = name;
            MaxCount = maxCount;
            
        }


        public void AddStudent(Student student)
        {

            students[students.Length - 1] = student;
            Students = students;
            Array.Resize(ref students, students.Length + 1);
            Console.WriteLine("Student Added");


        }
        public void RemoveStudent(Student student)
            {
            int a = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i] == student)
                {
                    Console.WriteLine($"{student.Name} {student.SurName} Romeved ");
                    
                }

                
               
            }


            for (int j = 0; j < Students.Length; j++)
            {
                int c = j+1;
                if (j!=a)
                {
                    
                    Students[j] = Students[c];

                }
                else
                {
                    Students[j] = Students[j+1];
                    j = j + 1;
                }

                
                
                



                }
        }

        







    }
}
