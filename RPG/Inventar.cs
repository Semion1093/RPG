using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Inventar
    {
        private LinkedList<Item> _myItem;

        public string Owner { get; set; }
        const int MaxItems = 10;
        public int Count { get; private set; }

        public Inventar()
        {
            _myItem = new LinkedList<Item>();
        }



    }


}
