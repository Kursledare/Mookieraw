﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Enums;
using Items.Interfaces;

namespace GameEquipment
{
    public abstract class Armor  : IArmor
    {
        private string _name;
        private  int  _armorValue;
        private string _armorType;


        public ArmorTypes ArmorType { get; protected set; }

        public string Name { get; protected set; }

        public int ArmorValue { get; protected set; }

    }
}
