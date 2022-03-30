using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class GroupManager
    {
        public void addStudent(Student student,Group group)
        {

            if (group.MaxCount>=group.Students.Length)
                {
                   
                    Console.WriteLine($"{student.Name} {student.SurName} added to {group.Name}");
            }
            
        }

        public void RemoveStudent(Student student,Group group)
        {
            Console.WriteLine($"{student.Name} {student.SurName} Romeved to {group.Name}");
        }
    }
}
