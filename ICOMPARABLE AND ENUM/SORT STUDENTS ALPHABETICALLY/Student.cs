namespace Exercise002
{
    using System;
    using System.Collections.Generic;

    public class Student : IComparable<Student>
    {

        public string name { get; }

        public Student(string name)
        {
            this.name = name;
        }
        public int CompareTo(Student another)
        {
            return this.name.CompareTo(another.name);
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
