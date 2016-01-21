using System.Dynamic;
using CommandHandler.enums;

namespace CommandHandler.interfaces
{
    public interface ICommandable
    {
        Commands CurrentCommands { get; set; }
        Commands AvailableCommands { get; }
        bool PlayerControlled { get; }
    }
}