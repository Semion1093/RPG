using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    class Inventar
    {
        public string Owner { get; set; }
        const int MaxItem = 10;
        public int Count { get; private set; }

        private Item[] _array;

        public Inventar()
        {
            _array = new Item[MaxItem];
        }
        public Inventar(string owner) : this()
        {
            Owner = owner;
        }

        public void Add(Item item)
        {

            if (Count < MaxItem)
            {
                _array[Count] = item;
                Count++;
            }
            else
                throw new Exception("Инвентарь переполнен!");
        }

        public Item GetByIndex(int index)
        {
            if (index >= 0 && index < Count)
            {
                return _array[index];
            }
            else
                throw new Exception("Неверный индекс");
        }
        public void RemoveAt(int index)
        {
            if (index <= 0 && index >= Count)
                throw new IndexOutOfRangeException("Индекс выходит за границы массива");

            else
            {
                int[] tmpArray = new int[Count - 1];

                for (int i = 0; i < index; i++)
                    tmpArray[i] = _array[index];
                for (int i = index + 1; i < Count; i++)
                    tmpArray[i - 1] = _array[index];
            }
        }

        public Item this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                    return _array[index];
                throw new Exception("Неверный индекс");
            }
            set
            {
                if (index >= 0 && index < Count)
                    _array[index] = value;
                else
                    throw new Exception("Неверный индекс");
            }
        }
        public Item this[string name]
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    if (_array[i].Name.ToUpper() == name.ToUpper())
                        return _array[i];
                }
                throw new Exception("Предмета с таким названием нет!");
            }
            set
            {
                for (int i = 0; i < Count; i++)
                {
                    if (_array[i].Name.ToUpper() == name.ToUpper())
                    {
                        _array[i] = value;
                        return;
                    }
                }
                throw new Exception("Предмета с таким названием нет!");
            }
        }
    }
}