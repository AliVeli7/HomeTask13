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


        public Group()
        {

        }


        public Group(string name, int maxCount)
        {
            Name = name;
            MaxCount = maxCount;
            
        }







    }
}
