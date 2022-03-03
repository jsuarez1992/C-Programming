using System;
using System.Collections.Generic;

namespace Exercise006
{
  public class Box : IPackable
  {
    public List<IPackable> list;
    private int maxCapacity;

    public Box(int maxCapacity)
    {
        this.maxCapacity = maxCapacity;
        this.list = new List<IPackable>();
    }
    public void Add (IPackable item)
    {
        if (Weight() + item.Weight()<=this.maxCapacity)
        {
            list.Add(item);
        }
    }
    public int Weight()
    {
        int sum=0;
        foreach (IPackable item in list)
        {
            sum = sum + item.Weight();
        }
        return sum;
    }
    public override string ToString()
    {
        return $"{list.Count} items, total weight {Weight()} kg";
    }
  }
}
