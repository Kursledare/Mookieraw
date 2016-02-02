using CommandHandler.enums;

namespace CommandHandler.interfaces
{
    /// <summary>
    /// To be used by objects that can be controlled(by player or computer).
    /// </summary>
    public interface ICommandable
    {
        /// <summary>
        /// Should return Commands that object can perform.
        /// </summary>
        Commands AvailableCommands { get; }
        /// <summary>
        /// Number of points that can be used in 1 turn, normaly 5 ?
        /// </summary>
        int NumberOfActionPointsPerTurn { get; }
        /// <summary>
        /// Is object controlled by player?
        /// </summary>
        bool PlayerControlled { get; set; }
        /// <summary>
        /// Add Command to be performed on Action()
        /// Should return true if successful
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool AddCommand(Commands command);
        /// <summary>
        /// Returns the next Command that should be performed.
        /// </summary>
        /// <returns></returns>
        Commands GetNextCommand();
    }
}