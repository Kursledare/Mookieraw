using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Races
{
    public class Elf : Race
    {
        public Elf()
        {
            Size = Size.Medium;
            Type = Type.Humanoid;
            Subrace = SubRace.Elf;
            BaseSpeed.Feet = 30;
        }
    }
}
