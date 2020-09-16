using System;
using System.Collections.Generic;
using System.Text;

namespace person
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        { 
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, int age)
        
        {
            this.name = name;
            this.age = age;
        }
        public string Getname(string name)
        {
            return  name;
        }
        public void Setname(string name)
        {
            this.name = name;
        }

        public int Getage (int age)
        {
            return age;
        }
        public void Setage(int age)
        {
            this.age = age;
        } 

        public void GetInfo()
        {
            Console.WriteLine("thong tin Person{0}",name);
            Console.WriteLine("thong tin Person{0}", age);
        }
    }
}
