using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Races
{
    public class Halfling : Race
    {
        public Halfling()
        {
            Size = Size.Small;
            Type = Type.Humanoid;
            Subrace = SubRace.Halfling;
            BaseSpeed.Feet = 20;
        }
    }
}
