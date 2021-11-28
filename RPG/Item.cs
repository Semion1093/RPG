using System;
using System.Collections.Generic;
using System.Text;

namespace RPG 
{
    enum ItemType { Gun, Сrossbow, Cudgel, Armor, Helmet, Cloak, Shoes };

    class Item
    {
        public string Name { get; set; }
        public ItemType ItemType { get; set; }
        public double Cost { get; set; }
        public int Weigth { get; set; }

        public Item() { }
        public Item(string name, ItemType itemType, double cost, int weigth)
        {
            Name = name;
            ItemType = itemType;
            Cost = cost;
            Weigth = weigth;
        }

        public static implicit operator int(Item v)
        {
            throw new NotImplementedException();
        }
    }
}
