using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityData.Races
{
    public class Goblin : Race
    {
        public Goblin()
        {
            Size = Size.Small;
            Type = Type.Humanoid;
            Subrace = SubRace.Goblin;
            BaseSpeed = new BaseSpeed(20);
        }
    }
}
