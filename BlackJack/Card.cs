using System;

namespace BlackJack
{
    public class Card
    {
        public string Suit { get; set; }

        public string Rank { get; set; }

        public override string ToString()
        {
            return Rank + " of " + Suit;
        }
    }
}

