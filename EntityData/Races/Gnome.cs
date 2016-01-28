using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Races
{
    public class Gnome : Race
    {
        public Gnome()
        {
            Size = Size.Small;
            Type = Type.Humanoid;
            Subrace = SubRace.Gnome;
            BaseSpeed.Feet = 20;
        }
    }
}
