using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Student : Person
    {
        public string ID { get; set; }
        public double Grade { get; set; }
        public Advisor Advisor { get; set; }

        public Student(string name, string major, string id, double grade, Advisor advisor) : base(name, major)
        {
            ID = id;
            Grade = grade;
            Advisor = advisor;
        }

    }
}
