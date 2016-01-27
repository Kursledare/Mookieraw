using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Races
{
    public class Dwarf : Race
    {
        public Dwarf()
        {
            base.Size = Size.Medium;
            base.Type = Type.Humanoid;
            base.Subrace = SubRace.Dwarf;
            base.BaseSpeed.Feet = 20;
        }
    }
}
