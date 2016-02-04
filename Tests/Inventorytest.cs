using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Items.Interfaces;
using EntityData;
using Items;
using Items.Weapons;

namespace Tests
{
    [TestFixture]
    class Inventorytest
    {
        //test to testing drop and pickupfunction in inventory.
        public List<IWeapon> Weapons { get; }
        public List<IArmor> Armor { get; }
        public List<IAdventureGear> AdventureGear { get; }
        public List<ArcaneImplement> ArcaneImplement { get; }
        public List<Ammmunition> Ammmunition { get; }




        [Test]
        public void CanPickUpAItem()
        {
            var weakBlade = new LongSword();
            var it = new List<IItems>();
            it.Add(weakBlade);
                        
            Assert.That(it.Any(x => string.Equals("Longsword", x.Name)));
        }
        [Test]
        public void DropAItem()
        {
            var weakBlade = new LongSword();
            var it = new List<IItems>();
            
            it.Remove(weakBlade);
            
            Assert.That(!it.Any(x => string.Equals("Longsword", x.Name)));
        }

        [Test]
        public void WhatIsAItem()
        {
            var closedCandle = new Waterskin();
            var it = new List<IItems>();
            it.Add(closedCandle);
            Assert.That(it.Any(x => string.Equals("Waterskin", x.Name)));
        } 

    }
}

