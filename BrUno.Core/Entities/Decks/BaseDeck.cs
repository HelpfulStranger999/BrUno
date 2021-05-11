using BrUno.Core.Entities.Cards;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography;

namespace BrUno.Core.Entities.Decks
{
    public abstract class BaseDeck : IDeck
    {
        protected IDeckFactory Factory { get; }

        protected Stack<Card> Cards { get; set; }
        ImmutableArray<Card> IDeck.Cards => Cards.ToImmutableArray();

        protected BaseDeck(IDeckFactory factory, IEnumerable<Card> cards)
        {
            Factory = factory;
            if (cards != null)
            {
                foreach (var card in cards)
                {
                    Cards.Push(card);
                }
            }
        }

        public abstract void ShuffleCards();
        protected Stack<Card> Shuffle()
        {
            var rng = new Random(RandomNumberGenerator.GetInt32(int.MinValue, int.MaxValue));
            var currentCards = Cards.ToList();
            var cards = new Stack<Card>();

            for (int i = currentCards.Count - 1; i > 0; i--)
            {
                cards.Push(currentCards[rng.Next(0, currentCards.Count)]);
            }

            return cards;
        }
    }
}