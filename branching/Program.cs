using System;

namespace branching
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("George");
            Console.WriteLine("Hello World!");
            
        }
    }
    class Student
    {
        public string Name { get; }
        public Student(string name)
        {
            name = Name;
        }
    }
}
