using BrUno.Core.Entities.Cards;
using System.Collections.Generic;

namespace BrUno.Core.Entities.Decks
{
    public class PlayableDeck : BaseDeck, IPlayableDeck
    {
        public PlayableDeck(IDeckFactory factory, IEnumerable<Card> cards) : base(factory, cards)
        {
        }

        public Card GetTopCard()
        {
            return Cards.Peek();
        }

        public void Play(Card card)
        {
            Cards.Push(card);
        }

        public override void ShuffleCards()
        {
            Cards = Shuffle();
        }
    }
}