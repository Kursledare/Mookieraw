using Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items.Interfaces;
using Items;

namespace EntityData
{
    public class Inventory
    {
        
        public List<IWeapon> Weapons { get; set; }
        public List<IArmor> Armor { get; set; }
        public List<Item> Items { get; set; }

        // You may want to see what you have in your Inventory This method does that.
        // Now is this method void, because open function isn't in function.
        // When it is finish, it shall response a list of items. 
        public void Open()
        {
            foreach (var weapon in Weapons)
            {
                Items.Add((Item)weapon);                        
            }
            foreach (var arm in Armor)
            {
                Items.Add((Item)arm);
            }
            foreach (var it in Items)
            {
             /// This function coming i next version.
             /// This function shall be connecting to GUI
             /// and show whole list.  
            }
        }

        // This method take up items from gameenviroment.
        public void PickUp(Item it)
        {
            Items.Add(it);
        }
        // This method drop a item from inventory back to gameinvorement.
        public void Drop(Item it)
        {
            Items.Remove(it);
        }
        // This method take the item from inventory to the equipment.

        /// 
        /// Dessa metoder diskuteras att flytta över till Equipment or Character.
        /// 
        /*
        public bool Equipweapon(Item invitem)
        {  
            foreach (var weapon in Weapons)
            {
                if (invitem is IWeapon)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
        // This method take the item from inventory to the equipment.
        public <IArmor> EquipArmor(Item invitem)
        {
            foreach (var arm in Armor)
            {
                if (invitem is IArmor)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
        // This method take items from equipment to the inventory.
        public void Dropdown()
        {
            
        }
        */
    }
}
