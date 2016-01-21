namespace TurnManager.interfaces
{
    public interface IGameObject
    {
        int Initiative { get;  }
        bool IsActive { get; }
        Vector2 Position { get; set; }
        IGameObject Target { get; set; }
        void Action();

    }
}