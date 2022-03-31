using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Student student1 = new Student(1,"Rowan","Nybhuy","Italian Language");
            Student student2 = new Student(2, "Neil", "Armstrong", "Math");
            Student student3 = new Student(3, "Rowan", "Navarro", "Italian Language");
            Group group1 = new Group("RT100",34);
            Group group2 = new Group("MR101",25);

            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.RemoveStudent(student1);




        }
    }
}
