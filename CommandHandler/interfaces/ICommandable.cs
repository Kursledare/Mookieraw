using CommandHandler.enums;

namespace CommandHandler.interfaces
{
    public interface ICommandable
    {
        Commands CurrentCommands { get; set; }
        Commands GetAvailableCommands();
        bool PlayerControlled { get; }
    }
}