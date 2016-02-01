using CommandHandler.enums;

namespace CommandHandler.interfaces
{
    public interface ICommandable
    {
        Commands AvailableCommands { get; }
        int NumberOfActionPointsPerTurn { get; }
        bool PlayerControlled { get; set; }
        bool AddCommand(Commands command);
        Commands GetNextCommand();
    }
}