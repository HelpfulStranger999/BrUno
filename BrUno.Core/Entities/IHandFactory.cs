using BrUno.Core.Entities.Cards;
using System.Collections.Generic;

namespace BrUno.Core.Entities
{
    public interface IHandFactory
    {
        public IHand CreateDefaultHand();
        public IHand CreateHand(IEnumerable<Card> cards);
        public IHand CreateHand(params Card[] cards);
    }
}