namespace GameEngine.interfaces
{
    /// <summary>
    /// The interface used by GameManager to handle Objects that are in the game.
    /// </summary>
    public interface IGameObject
    {
        int Initiative { get;  }
        /// <summary>
        /// Determines if Action is invoked on the object in RunTurn. Should be true when "Alive" and false when "Dead".
        /// </summary>
        bool IsActive { get; }
        Vector2 Position { get; set; }
        ScreenObject ScreenObject { get; set; }
        Vector2 MovePosition { get; set; }
        IGameObject Target { get; set; }
        /// <summary>
        /// Invoked by GameManager in RunTurn. Needs to perform the Actions that the Object is going to do in the turn.
        /// </summary>
        void Action();
    }
}