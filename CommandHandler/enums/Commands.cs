using System;

namespace CommandHandler.enums
{
    [Flags]
    public enum Commands
    {
        None=0,
        Withdraw=1,
        Run=2,
        MeleeAttack=4,
        RangedAttack=8,
        UnarmedAttack=16,
        FullAttack=32,
        CastSpell=64,
        Move=128,
        Crawl=256,
        DrawWeapon=512,
        ManipulateItem=1024,
        StandUp=2048,
        DropItem=4096,
        DropProne=8192,
        Talk=16384,
        MoveFiveFeet=32768,
        DelayAction=65536,
        ReadyAction=131072
    }
}