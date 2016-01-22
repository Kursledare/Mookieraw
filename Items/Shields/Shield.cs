using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Enums;
using Items.Interfaces;

namespace Items.Shields
{
    public abstract class Shield : IShield
    {
        public string Name { get; protected set; }
        public ArmorTypes ArmorType { get; protected set; }
        public int ArmorValue { get; protected set; }
    }
}
