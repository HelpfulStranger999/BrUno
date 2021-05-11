using BrUno.Core.Entities.Cards;
using System.Collections.Generic;

namespace BrUno.Core.Entities.Decks
{
    public interface IDeckFactory
    {
        public IPlayableDeck CreateDefaultPlayableDeck();
        public IPlayableDeck CreatePlayableDeck(IEnumerable<Card> cards);

        public IDrawableDeck CreateDefaultDrawableDeck();
        public IDrawableDeck CreateDrawableDeck(IEnumerable<Card> cards);
    }
}