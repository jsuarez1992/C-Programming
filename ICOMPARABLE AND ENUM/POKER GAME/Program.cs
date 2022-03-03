using System;

namespace Exercise005
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Card first = new Card(2, Suit.Diamond);
            Card second = new Card(14, Suit.Spade);
            Card third = new Card(12, Suit.Heart);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
