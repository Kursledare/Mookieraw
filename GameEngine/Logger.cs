using System;
using System.Collections.Generic;
using System.IO;

namespace GameEngine
{
    public static class Debug
    {
        public static readonly List<string> DebugLog = new List<string>();
        public static Action<string> OnErrorLogEntry;
        /// <summary>
        /// Log a debug message here, or an error
        /// </summary>
        /// <param name="message"></param>
        public static void Log(string message)
        {
            DebugLog.Add(message);
            OnErrorLogEntry?.Invoke(message);
        }

        public static void LogToDisk(string message)
        {
            var path = @"c:\code\debugLog.txt";

            if (File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write("========\n");
                    sw.Write(message);
                }
            }

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
            OnGameLoggedEntry?.Invoke(message);
        }
    }
}
