namespace BrUno.Core.Entities.Games
{
    public enum GameStateType
    {
        PlayerTurnConsumed,
        TurnOrderAltered
    }

    public class GameStateResult
    {
        public GameStateType 
        public string Message { get; }

    }
}