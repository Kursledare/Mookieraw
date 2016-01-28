using System.Collections.Generic;

namespace EntityData
{
    public class Race
    {
        public Attributes RaceModifier { get; set; }
        public Size Size { get; set; }
        public Type Type { get; set; }
        public SubRace Subrace { get; set; }
        public BaseSpeed BaseSpeed { get; set; }
    }

    public class BaseSpeed
    {
        public int Tiles => Feet / 5;
        public int Feet { get; set; }
    }

    public enum Size
    {
        Fine, Diminutive, Tiny, Small, Medium, LargeTall, LargeLong, HugeTall, HugeLong, GargantuanTall, GargantuanLong, ColossalTall, ColossalLong
    }
    public enum Type
    {
        Animal, Dragon, Fey, Humanoid, MagicalBeast, Ooze, Plant, Undead, Vermin
    }
    public enum SubRace
    {
        Human, Dwarf, Elf, Gnome, Halfling
    }
}
