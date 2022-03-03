using System;

namespace Exercise008
{
    public abstract class Animal
    {
        public string name { get;}
        public Animal (string name)
        {
            this.name = name;
        }
        public void Eat()
        {
         Console.WriteLine( this.name + " eats");
        }
        public void Sleep()
        {
         Console.WriteLine( this.name + " sleeps");
        }
    }
}
