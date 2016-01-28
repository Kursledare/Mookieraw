using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Races
{
    public class Human : Race
    {
        public Human()
        {
            Size = Size.Medium;
            Type = Type.Humanoid;
            Subrace = SubRace.Human;
            BaseSpeed.Feet = 30;
        }
    }
}
