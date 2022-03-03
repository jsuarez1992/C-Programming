namespace Exercise005
{
    using System;
    using System.Collections.Generic;

    public class Hand  : IComparable<Hand>
    {
        private List<Card> cards;

        public Hand()
        {

            this.cards = new List<Card>();

        }

        public void Add(Card card)
        {
            if (!this.cards.Contains(card))
            {
                this.cards.Add(card);
            }
        }
        public void Print()
        {
            this.cards.ForEach(Console.WriteLine);
        }

        public void Sort()
        {
            this.cards.Sort();
        }
        public int CompareTo(Hand other)
        {
            int baseSum = 0;
            int otherSum = 0;

            foreach (Card item in cards)
            {
                baseSum+=item.value;
            }
            foreach (Card item in other.cards)
            {
                otherSum+=item.value;
            }
            if(baseSum<otherSum)
            {
                return -1;
            }
            else if (baseSum>otherSum)
            {
                return 1;
            }
            else
            {
            return 0;
            }
        }


    }
}
