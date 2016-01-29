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
        public bool CanSpeak;
    }

    public class BaseSpeed
    {
        private readonly int _feet;
        public int Tiles => _feet / 5;

        public BaseSpeed(int feet)
        {
            _feet = feet;
        }
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
        Human, Dwarf, Elf, Gnome, Halfling, Goblin 
    }

    public enum Languages
    {
        Aboleth, Abyssal, Aklo, Aquan, Auran, Boggard, Celestial, Common, Cyclops, DarkFolk, Draconic, DrowSignLanguage, Druidic, Dwaren, Dziriak, Elven, Giant, Gnoll, Gnome, Goblin, Grippli, Halfling,
        Ignan, Infernal, Necril, Orc, Protean, Sphinx, Sylvan, Tengu, Terran, Treant, Undercommon, Vegepygmy
    }
}
