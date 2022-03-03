using System;
using System.Collections.Generic;

namespace Exercise008
{
    public class Cat : Animal, INoiseCapable
    {
        public Cat() : this("Cat")
        {
        }

        public Cat(string name) : base(name)
        {
        }

        public void Purr()
        {
            Console.WriteLine(this.name + " purrs");
        }

        public void MakeNoise()
        {
            Purr();
        }

    }
}
