using Homework09Advanced.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework09Advanced.classPerson
{
    public class Person 

    {
        public string Name { get; set; }    
        public string Surname { get; set; }
        public int Age { get; set; }
        public List <Course> Courses { get; set; }
    }
}
