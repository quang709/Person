using System;
using System.Collections.Generic;
using System.Text;

namespace person
{
    class Human :Person
    {

        public string gender;

        public void GetInfo()
        {
            Console.WriteLine("name{0}",name);
            Console.WriteLine("age{0}", name);
            Console.WriteLine("gender{0}", gender);
        }

        public Human(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}
