using System;

namespace CommandHandler.enums
{
    [Flags]
    public enum Commands
    {
        Attack=1,
        Move=2,
        Defend=4
    }
}