namespace Exercise
{
    using System;
    using System.Collections.Generic;
    public class Hand : IComparable<Hand>
    {
        private List<Card> hand;
        public Hand()
        {
            this.hand = new List<Card>();
        }
        public void Add(Card card)
        {
            if (this.hand.Contains(card))
            {
                return;
            }
            else
            {
                this.hand.Add(card);
            }
        }

        public void Print()
        {
            foreach (Card kortit in this.hand)
            {
                Console.WriteLine(kortit.ToString());
            }
        }

        public void Sort()
        {
            this.hand.Sort();
        }


        public int CompareTo(Hand hand)
        {
            int sum = 0;
            foreach (Card cards in this.hand)
            {
                sum += cards.value;
            }
            int sum2 = 0;
            foreach (Card cards in hand.hand)
            {
                sum2 += cards.value;
            }
            if (sum == sum2)
            {
                return 0;
            }
            if (sum < sum2)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }
}