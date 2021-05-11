using BrUno.Core.Entities.Cards;
using System.Collections.Immutable;

namespace BrUno.Core.Entities.Decks
{
    public interface IDeck
    {
        public ImmutableArray<Card> Cards { get; }
        void ShuffleCards();
    }
}