using System;
using System.Text;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {

            Human human = new Human("aaaa",22,"dasd");

            Console.WriteLine("name{0}", human.name);
            Console.WriteLine("age{0}", human.name);
            Console.WriteLine("gender{0}", human.gender);
        }


    }
}
