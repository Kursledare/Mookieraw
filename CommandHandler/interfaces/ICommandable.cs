using CommandHandler.enums;

namespace CommandHandler.interfaces
{
    public interface ICommandable
    {
        Commands AvailableCommands { get; }
        int NumberOfCommandsPerTurn { get; }
        bool PlayerControlled { get; }
        bool AddCommand(Commands commands);
        Commands GetNextCommand();
    }
}