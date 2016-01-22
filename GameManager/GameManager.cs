using System.Collections.Generic;
using System.Linq;
using CommandHandler.interfaces;
using EntityData;
using EntityData.Characters;
using static TurnManager.TurnManager;

namespace GameManager
{
    /// <summary>
    ///     Absolute work in progress, party is all the characters we can command,
    ///     Avalible targets is right now all the others, later on we can do distance checks between the current character
    ///     and the targets availible.
    ///     CurrentCharacter is the Character we are assigning Actions for right now.
    ///     When we have made all the actions for all our party members, we call proceed.
    ///     Proceed will Tell the turnmanager to run the turn.
    /// </summary>
    public static class GameManager
    {
        public static List<Character> AvailibleTargets => (from gameObject in GameObjects.OfType<ICommandable>()
            where gameObject.PlayerControlled == false
            select gameObject as Character).ToList();

        public static List<Character> Party
            =>
                (from gameObject in GameObjects.OfType<ICommandable>()
                    where gameObject.PlayerControlled
                    select gameObject as Character).ToList();

        public static Character CurrentCharacter { get; set; }


        public static void Proceed()
        {
            //if all our characters have actions =>
            RunTurn();
        }
    }
}