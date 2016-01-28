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
        public List<IWeapon> Weapons { get; set; }
        public List<IArmor> Armor { get; set; }
        public List<Item> Items { get; set; }



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
    }
}

