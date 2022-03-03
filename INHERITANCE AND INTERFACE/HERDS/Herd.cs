using System;
using System.Collections.Generic;

namespace Exercise007
{
    public class Herd : IMovable
    {
        private List<IMovable> list;

        public Herd()
        {
            this.list = new List<IMovable>();

        }
        public void AddToHerd(IMovable movable)
        {
            this.list.Add(movable);
        }
        public void Move(int dx, int dy)
        {
            foreach (IMovable creature in list)
            {
                creature.Move(dx,dy);
            }
        }
        public override string ToString()
        {
            string s="";
            foreach (IMovable creature in this.list)
            {
                s += creature.ToString() + "\n";
            }
            return s;
        }
    }
}
