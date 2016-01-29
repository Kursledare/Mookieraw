using CommandHandler.enums;

namespace CommandHandler.interfaces
{
    public interface ICommandable
    {
        Commands AvailableCommands { get; }
        int NumberOfActionPointsPerTurn { get; }
        bool PlayerControlled { get; }
        bool AddCommand(Commands command);
        Commands GetNextCommand();
    }
}