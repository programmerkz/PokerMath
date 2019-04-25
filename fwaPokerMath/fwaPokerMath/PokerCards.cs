using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fwaPokerMath
{
    enum CardSuit : byte
    {
        Hearts,
        Tiles,
        Clovers,
        Pikes,

        Diamonds = Tiles,
        Clubs = Clovers,
        Spades = Pikes
    }

    enum CardRank : byte
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,

        Knave = Jack,
        Valet = Jack,
        Lady = Queen,
        Dame = Queen
    }

    

    class PlayingCard
    {
        public CardRank Rank { get; }
        public CardSuit Suit { get; }
        

        public PlayingCard(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
        }

    }
}
