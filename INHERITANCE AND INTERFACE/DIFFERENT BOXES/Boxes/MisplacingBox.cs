using System;
using System.Collections.Generic;
namespace Exercise004
{
    public class MisplacingBox : Box
    {
        private List<Item> list;
        public MisplacingBox()
        {
            this.list = new List<Item>();
        }
        public override void Add(Item item)
        {
            list.Add(item);
        }
        public override bool IsInBox(Item item)
        {
            return false;
        }

    }
}
