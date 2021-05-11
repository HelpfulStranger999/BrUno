using BrUno.Core.Entities.Cards;

namespace BrUno.Core.Entities
{
    public interface IHand
    {
        void Draw(Card card);
        void Play(Card card);
    }
}