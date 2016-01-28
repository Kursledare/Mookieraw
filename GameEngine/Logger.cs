using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace GameEngine
{
    public static class Debug
    {
        public static readonly List<string> DebugLog = new List<string>();
        public static Action<string> OnErrorLogEntry;
        /// <summary>
        /// Log a debug message here, or an error
        /// TODO should write to a .txt on disk?
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {
            DebugLog.Add(message);
            OnErrorLogEntry(message);
            StreamWriter writer = File.CreateText(@"c:\code\debug.txt");
            writer.WriteLine(message);
        }
    }
    public static class Game
    {
        public static readonly List<string> GameLog = new List<string>();
        public static Action<string> OnGameLoggedEntry;
        /// <summary>
        /// Log a message to the gameLog
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {
            GameLog.Add(message);
            OnGameLoggedEntry(message);

        }
    }
}
