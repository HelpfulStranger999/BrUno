using BrUno.Core.Entities.Cards;

namespace BrUno.Core.Entities.Decks
{
    public interface IPlayableDeck : IDeck
    {
        public void Play(Card card);
        public Card GetTopCard();
    }
}