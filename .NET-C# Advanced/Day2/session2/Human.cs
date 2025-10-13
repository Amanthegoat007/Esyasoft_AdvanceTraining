using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session2
{
    internal class Human(int age, string name)
    {
        public string name = name;
        public int age = age;
        //public Human(int age, string name) {
        //    this.age = age;
        //    this.name = name;
        //}
        public void Eat()
        {
            Console.WriteLine($"Hey, Wanna eat,{this.name}!!");
        }
    }
}
