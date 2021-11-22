using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    abstract class Creature
    {
        private string _name;
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Вы ничего не ввели! ");
                }
                else
                {
                    _name = value;
                }
            }
            get
            {
                return _name;
            }
        }

        private int _hp;
        public int HP
        {
            set
            {
                if (value > 0 && value < MaxHP)
                {
                    _hp = value;
                }
                else
                {
                    throw new Exception("Некорректный HP!");
                }
            }
            get
            {
                return _hp;
            }
        }

        private int _maxhp;
        public int MaxHP
        {
            set
            {
                if (value > 0 && value <= 500)
                {
                    _maxhp = value;
                }
                else
                {
                    throw new Exception("Некорректный HP!");
                }
            }
            get
            {
                return _maxhp;
            }
        }

        public bool IsDie { get; set; }
        public string IsDieText
        {
            get
            {
                if (IsDie == true) return "Жив";
                else return "Мертв";
            }
        }

        public abstract int Hurt();
    }

}
