using System;
using System.Collections.Generic;
namespace Exercise004
{
    public class BoxWithMaxWeight : Box
    {
        public List<Item> list;
        private int capacity;

        public BoxWithMaxWeight(int capacity)
        {
            this.capacity = capacity;
            this.list = new List<Item>();
        }
        public override void Add(Item item)
        {
            if (this.WeightOfItems() + item.weight > this.capacity)
            {
                return;
            }
            this.list.Add(item);
        }
        private int WeightOfItems()
        {
            int weight = 0;
            foreach (Item item in this.list)
            {
                weight += item.weight;
            }
            return weight;
        }
        public override bool IsInBox(Item item)
        {
            if (list.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
